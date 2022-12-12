using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
class Program
{
    public class Node
    {
        public Node next;
        public object data;
    }
    public class MyStack
    {
        public Node top;
        public bool IsEmpty()
        {
            return top == null;
        }
        public void Push(object ele)
        {
            Node n = new Node();
            n.data = ele;
            n.next = top;
            top = n;
        }
        public Node Pop()
        {
            if (top == null)
                return null;
            Node d = top;
            top = top.next;
            return d;
        }
        public Node Peek()
        {
            return top;
        }
    }

    // Functions are used to process algorithms
    // Các hàm xử lý thuật toán
    static bool IsNumber(string pValue)
    {
        if (compare(pValue) == -1)
        {
            for (int i = 0; i < pValue.Length; i++)
            {
                if (i == 0)
                {
                    if (pValue[i] == '-' && Char.IsDigit(pValue[i + 1]))
                    {
                        continue;
                    }
                }
                if (pValue[i] == '.')
                    continue;
                if (!Char.IsDigit(pValue[i]))
                    return false;
            }
            return true;
        }
        else
        {
            return false;
        }
    }
    // Hàm kiển tra một giá trị của phải là toán tử hay không
    static int compare(string c)
    {
        switch (c)
        {
            case "+":
            case "-":
                return 1;

            case "*":
            case "/":
                return 2;

            case "^":
                return 3;
        }
        return -1;
    }
    // Hàm chuyển biểu thức từ infix sang postfix
    static string infixToPostfix(string[] inFix)
    {
        MyStack ms = new MyStack();
        // Tạo một Stack và một output (string)
        string postFix = "";
        for (int i = 0; i < inFix.Length; i++)
        {
            string c = inFix[i];
            // Nếu là toán hạng: cho ra output.
            if (IsNumber(c))
            {
                postFix += (c + " ");
            }
            // Nếu là dấu mở ngoặc “(“: cho vào stack
            else if (c == "(")
            {
                ms.Push(c);
            }
            /**Nếu là dấu đóng ngoặc “)”: lấy các toán tử trong stack ra 
            và cho vào output cho đến khi gặp dấu mở ngoặc “(“. 
            (Dấu mở ngoặc cũng phải được đưa ra khỏi stack)**/
            else if (c == ")")
            {
                while (!ms.IsEmpty() && (string)ms.top.data != "(")
                {
                    postFix += (ms.Pop().data + " ");
                }

                if (!ms.IsEmpty() && (string)ms.top.data != "(")
                {
                    throw new Exception();
                }
                else
                {
                    ms.Pop();
                }
            }
            /**Nếu là toán tử:
            - Chừng nào ở đỉnh stack là toán tử và toán tử đó có độ ưu tiên lớn hơn 
            hoặc bằng toán tử hiện tại thì lấy toán tử đó ra khỏi stack và cho ra output.
            - Đưa toán tử hiện tại vào stack.
            **/
            else
            {
                while (!ms.IsEmpty() && compare(c) <= compare((string)ms.top.data))
                {
                    postFix += (ms.Pop().data + " ");
                }
                ms.Push(c);
            }
        }
        /**Sau khi duyệt hết biểu thức infix, nếu trong stack còn phần tử 
        thì lấy các phần tử trong đó ra và cho lần lượt vào output.**/
        while (!ms.IsEmpty())
        {
            postFix += (ms.Pop().data + " ");
        }
        return postFix.TrimEnd();
    }
    // Hàm tính toán biểu thức
    static float evaluateExp(string[] postFix)
    {
        // Tạo một Stack và một result (float)
        MyStack ms = new MyStack();
        float result = 0;
        for (int i = 0; i < postFix.Length; i++)
        {
            string c = postFix[i];
            // Nếu là toán hạng: push vào Stack
            if (IsNumber(c))
            {
                ms.Push(c);
            }
            /** Nếu là toán tử: pop hai toán hạng trong Stack ra và 
            tính giá trị của chứng dựa vào toán tử này, sau đó push kết quả vào lại Stack **/
            else
            {
                float operand1 = float.Parse((string)ms.Pop().data);
                float operand2 = float.Parse((string)ms.Pop().data);

                if (c == "+")
                {
                    ms.Push((operand1 + operand2).ToString());
                }
                else if (c == "-")
                {
                    ms.Push((operand2 - operand1).ToString());
                }
                else if (c == "*")
                {
                    ms.Push((operand1 * operand2).ToString());
                }
                else if (c == "/")
                {
                    ms.Push((operand2 / operand1).ToString());
                }
                else if (c == "^")
                {
                    ms.Push(Math.Pow(operand2, operand1).ToString());
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        /** Sau khi duyệt hết phần tử của biểu thức, 
        phần tử còn sót lại trong Stack sau khi lặp qua các phần tử là kết quả của biểu thức, 
        gán kết quả đó cho result.**/
        result = float.Parse((string)ms.Pop().data);
        if (!ms.IsEmpty())
        {
            throw new Exception();
        }
        return result;
    }

    // Result Here !!!
    // Hàm thực hiện thuật toán
    static float CalculateExp(string exp)
    {
        float result = 0;
        string[] arrExp = exp.Split(' ');
        string str = infixToPostfix(arrExp);
        string[] arrStr = str.Split(' ');
        result = evaluateExp(arrStr);
        return result;
    }

    // Kiểm tra xem biểu thức nhập vào có hợp lệ hay không
    static bool check_Expression(string exp)
    {
        try
        {
            CalculateExp(exp);
        }
        catch
        {
            return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.Write("Nhập biểu thức Infix (giữa các toán tử và toán hạng phải có khoảng trắng ví dụ: 12 + 6 ^ 7 + ( 3 * 4 / 2 ) ) : ");
            string exp = Console.ReadLine();
            if (check_Expression(exp))
            {
                float result = CalculateExp(exp);
                Console.WriteLine("Kết quả: " + result);
                break;
            }
            else
            {
                Console.WriteLine("Biểu thức không hợp lệ, vui lòng thử lại");
            }
        }
        Console.WriteLine("Chương trình kết thúc");

        Console.ReadLine();
    }
}
