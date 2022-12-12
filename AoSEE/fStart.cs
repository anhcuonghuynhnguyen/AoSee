using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AoSEE
{
    public partial class fStart : Form
    {
        public fStart()
        {
            InitializeComponent();
            this.Icon = ResourcePic.LogoIcon1;

            // Thiết lập lại màu và font chữ như cài đặt ở form Setting
            if (Global.color == "Default")
            {
                tbExp.ForeColor = Color.Black;
                tbPostfix.ForeColor = Color.Black;
                tbResult.ForeColor = Color.Black;
            }
            else if (Global.color == "Blue")
            {
                tbExp.ForeColor = Color.Blue;
                tbPostfix.ForeColor = Color.Blue;
                tbResult.ForeColor = Color.Blue;
            }
            else
            {
                tbExp.ForeColor = Color.Red;
                tbPostfix.ForeColor = Color.Red;
                tbResult.ForeColor = Color.Red;
            }
            if (Global.font== "Arial")
            {
                tbExp.Font = new Font("Arial", 15); 
                tbPostfix.Font = new Font("Arial", 15);
                tbResult.Font = new Font("Arial", 15);
            } 
            else
            {
                tbExp.Font = new Font("Time New Romans", 15);
                tbPostfix.Font = new Font("Time New Romans", 15);
                tbResult.Font = new Font("Time New Romans", 15);
            }
        }
        // Stack Object
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
        }

        // Function Event
        // Event button Exit
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event Click Calculate Button
        private void btnCal_Click(object sender, EventArgs e)
        {
            tbResult.Text = string.Empty;
            string exp = tbExp.Text;
            if (check_Expression(exp))
            {
                tbResult.Text = CalculateExp(exp).ToString();
                tbPostfix.Text = infixToPostfix(exp.Split());
                SavetoFile(exp, tbResult.Text, tbPostfix.Text);
            }
            else
            {
                MessageBox.Show("The expression is not valid, Please check again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event Click Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbExp.Text = string.Empty;
            tbResult.Text = string.Empty;
            tbPostfix.Text = string.Empty;
        }
        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = ResourcePic.HoverExit;
            btnDelete.ForeColor = Color.White;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = ResourcePic.btnExit;
            btnDelete.ForeColor = Color.Red;
        }

        // Event Click Copy Button
        private void btnCopyRe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text))
            {
                Clipboard.SetText(tbResult.Text);
            }
        }
        private void btnCopyPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPostfix.Text))
            {
                Clipboard.SetText(tbPostfix.Text);
            }
        }
        // Event click Ques button
        private void btnQues_Click(object sender, EventArgs e)
        {
            fHelp fhelp = new fHelp();
            this.Hide();
            fhelp.ShowDialog();
            this.Show();
        }
        // Event type expression
        private void tbExp_TextChanged(object sender, EventArgs e)
        {
            string exp = tbExp.Text;
            if (check_Expression(exp))
            {
                lbValid.Text = "The expresion is valid";
                btnCal.BackgroundImage = ResourcePic.HoverStart;
            }
            else
            {
                lbValid.Text = "The expression is not valid";
                btnCal.BackgroundImage = ResourcePic.btnStart1;
            }
        }

        // Event hover button help
        private void btnQues_MouseHover(object sender, EventArgs e)
        {
            tooltipHover.Show("Help", btnQues);
        }

        // Function Program
        // Kiểm tra xem biểu thức nhập vào có hợp lệ hay không
        private bool check_Expression(string exp)
        {
            try {
                CalculateExp(exp);
            } 
            catch 
            { 
                return false;
            }
            return true;
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
        // Hàm tính toán biểu thức
        static float evaluateExp(string[] postFix)
        {
            MyStack ms = new MyStack();
            float result = 0;
            for (int i = 0; i < postFix.Length; i++)
            {
                string c = postFix[i];

                if (IsNumber(c))
                {
                    ms.Push(c);
                }
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

            result = float.Parse((string)ms.Pop().data);
            if (!ms.IsEmpty())
            {
                throw new Exception();
            }
            return result;
        }

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
            string postFix = "";
            for (int i = 0; i < inFix.Length; i++)
            {
                string c = inFix[i];

                if (IsNumber(c))
                {
                    postFix += (c + " ");
                }
                else if (c == "(")
                {
                    ms.Push(c);
                }
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
                else
                {
                    while (!ms.IsEmpty() && compare(c) <= compare((string)ms.top.data))
                    {
                        postFix += (ms.Pop().data + " ");
                    }
                    ms.Push(c);
                }
            }

            while (!ms.IsEmpty())
            {
                postFix += (ms.Pop().data + " ");
            }
            return postFix.TrimEnd();
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

        // Functions are used to crate, read, write to files
        // Các hàm ghi lại kết quả vào file
        static void Write2File(ArrayList ct, String path)
        {
            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                for (int i = 0; i < ct.Count; i++)
                    sw.WriteLine(ct[i]);
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.CreateText(path);
                for (int i = 0; i < ct.Count; i++)
                    sw.WriteLine(ct[i]);
                sw.Close();
            }
        }
        static void SavetoFile(string exp, string result, string postfix)
        {
            string path = Global.path;
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }

            ArrayList wt = new ArrayList();
            string time = DateTime.Now.ToString("HH:mm:ss");
            string day = DateTime.Today.ToString("dd-MM-yyyy");
            wt.Add($"{time} - {day} : \n\tExpression: {exp} \n\tResult: {result} \n\tPostFix: {postfix}\n");
            Write2File(wt, path);
        }
    }
}
