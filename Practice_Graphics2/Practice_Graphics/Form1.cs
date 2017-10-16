using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Graphics
{
    
    public struct node
    {
        public float x;
        public float y;
        public string id;
        //public float value;
    }
    public struct Path
    {
        public string PointS;
        public string PointE;
        public int path;
    }
    public partial class FrmMS : Form
    {
        List<node> LNode = new List<node>();
        List<Path> LPath = new List<Path>();
        public Array a;
        public int i;
        Graphics g;
        SolidBrush sb;
        public Label lb { get; set; }
        public FrmMS()
        {
            InitializeComponent();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            lblMess.Text = "Click anywhere on graph to draw point";
            sb = new SolidBrush(Color.IndianRed);
            g = panelMT.CreateGraphics();
            //i++;
        }
        private void panelMT_Click(object sender, MouseEventArgs e)
        {
           
        }
        private void panelMT_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.Location.X, e.Location.Y);
            lb = new Label();
            node n = new node();
            FrmNamePoint frmPN = new FrmNamePoint();
            frmPN.ShowDialog();
            if (CheckID(LNode, frmPN.Name)==false)
            {
                lb.Text = frmPN.Name;
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Location = p;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.BackColor = Color.IndianRed;
                lb.Size = new System.Drawing.Size(20, 30);

                g.FillEllipse(sb, e.Location.X - 15, e.Location.Y - 15, 50, 50);
                n.x = e.Location.X;
                n.y = e.Location.Y;
                n.id = lb.Text;
                LNode.Add(n);
                sb.Dispose();
                g.Dispose();
                panelMT.Controls.Add(lb);
                lblMess.Text = "Add point successfully";
            }
            else
            {
                lblMess.Text = "Add Point Failed !!! Point name already exist";
            }

        }

        private void line_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "" && txtPE.Text != "" && txtPS.Text != "")// kiểm tra người dùng nhập đủ các ô hay không
            {
                if (CheckID(LNode, txtPE.Text) == true && CheckID(LNode, txtPE.Text) == true)//kiểm tra point có tồn tại hay không
                {
                    node a1 = new node();
                    node a2 = new node();
                    string a = txtPS.Text;
                    string b = txtPE.Text;
                    for (i = 0; i < LNode.Count; i++)
                    {
                        if (a == LNode[i].id)
                        {
                            a1 = LNode[i];
                        }
                        if (b == LNode[i].id)
                        {
                            a2 = LNode[i];
                        }
                    }
                    // Vẽ đường nối 
                    Pen p = new Pen(Color.IndianRed);
                    sb = new SolidBrush(Color.Yellow);
                    g = panelMT.CreateGraphics();
                    g.DrawLine(p, a1.x, a1.y, a2.x, a2.y);
                    // Tạo lb chi phí
                    lb = new Label();
                    lb.Location = new Point(Convert.ToInt32((a1.x + a2.x) / 2), Convert.ToInt32((a1.y + a2.y) / 2));
                    lb.Size = new System.Drawing.Size(20, 20);
                    lb.Text = txtPath.Text;
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelMT.Controls.Add(lb);
                    // Gán chi phí vào path
                    Path p1 = new Path();
                    p1.PointS = txtPS.Text;
                    p1.PointE = txtPE.Text;
                    p1.path = Convert.ToInt32(txtPath.Text);
                    LPath.Add(p1);
                    lblMess.Text = "Add Line successfully ";
                }
                else { lblMess.Text = "Add Line Failed !!! One or both point doesn't exist  "; }
            }
            else
            {
                lblMess.Text = "Add Line Failed !!! You need to fill all information to add line ";
            }
        }
        public bool CheckID(List<node> LNode, string id)
        {
            for (i = 0; i < LNode.Count; i++)
            {
                if (LNode[i].id.Equals(id))
                    return true;
            }
            return false;
        }
    }

}
