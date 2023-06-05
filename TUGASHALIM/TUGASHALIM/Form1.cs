using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TUGASHALIM
{
    public partial class FormEquipment : Form
    {
        public FormEquipment()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string connectionString;
        string sqlQuery;

        PictureBox p1 = new PictureBox();
        PictureBox p2 = new PictureBox();
        PictureBox p3 = new PictureBox();
        PictureBox p4 = new PictureBox();

        Panel layout = new Panel();
        DataTable eq = new DataTable();
        DataTable eqdesc = new DataTable();

        List<PictureBox> piclist= new List<PictureBox>();
        List<TextBox> textBoxList=new List<TextBox>();
        static List<String> eqname = new List<String>() {"Weapon","Helmet","Armor","Boots","Auxillary"};
        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=RPGtheGame";
            conn = new MySqlConnection(connectionString);
            this.Size = new Size(1132,524);
            this.FormBorderStyle = FormBorderStyle.None;
            p1.Location = new Point(28, 38);
            p1.Size = new Size(100, 100);
            p1.Image = listimage.Images[5];
            p1.SizeMode = PictureBoxSizeMode.StretchImage;
            p1.BorderStyle = BorderStyle.Fixed3D;
            p1.Tag = "1";
            p1.Click += P1_Click;
            Controls.Add(p1);
            p2.Location = new Point(28, 145);
            p2.Size = new Size(100, 100);
            p2.Image = listimage.Images[5];
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            p2.BorderStyle = BorderStyle.Fixed3D;
            p2.Click += P1_Click;
            p2.Tag = "2";
            Controls.Add(p2);
            p3.Location = new Point(28, 252);
            p3.Size = new Size(100, 100);
            p3.Image = listimage.Images[5];
            p3.SizeMode = PictureBoxSizeMode.StretchImage;
            p3.BorderStyle = BorderStyle.Fixed3D;
            p3.Click += P1_Click;
            p3.Tag = "3";
            Controls.Add(p3);
            p4.Location = new Point(28, 359);
            p4.Size = new Size(100, 100);
            p4.Image = listimage.Images[5];
            p4.SizeMode = PictureBoxSizeMode.StretchImage;
            p4.BorderStyle = BorderStyle.Fixed3D;
            p4.Click += P1_Click;
            p4.Tag = "4";
            Controls.Add(p4);
            layout.Location = new Point(227, 38);
            layout.Size = new Size(700, 420);
            layout.BackColor = Color.LightGray;
            Controls.Add(layout);
            
           
        }
        int helper = 0;
        TextBox weapontxt = new TextBox();
        TextBox helmettxt = new TextBox();
        TextBox armortxt = new TextBox();
        TextBox bootstxt = new TextBox();
        TextBox auxillarytxt = new TextBox();
        private void P1_Click(object sender, EventArgs e)
        {
            helper++;
            layout.Controls.Clear();
            PictureBox weapon = new PictureBox();
            weapon.Location = new Point(20,40);
            weapon.Size = new Size(55, 55);
            weapon.Image = listimage.Images[0];
            weapon.SizeMode = PictureBoxSizeMode.StretchImage;
            weapon.BorderStyle = BorderStyle.FixedSingle;
            weapon.Tag = "E1";
            weapon.Click += SetEquip_Click;
            weapon.Cursor = Cursors.Hand;
            layout.Controls.Add(weapon);

            PictureBox helmet = new PictureBox();
            helmet.Location = new Point(20, 105);
            helmet.Size = new Size(55, 55);
            helmet.Image = listimage.Images[1];
            helmet.SizeMode = PictureBoxSizeMode.StretchImage;
            helmet.BorderStyle = BorderStyle.FixedSingle;
            helmet.Tag = "E2";
            helmet.Click += SetEquip_Click;
            helmet.Cursor = Cursors.Hand;
            layout.Controls.Add(helmet);

            PictureBox armor = new PictureBox();
            armor.Location = new Point(20, 170);
            armor.Size = new Size(55, 55);
            armor.Image = listimage.Images[2];
            armor.SizeMode = PictureBoxSizeMode.StretchImage;
            armor .BorderStyle = BorderStyle.FixedSingle;
            armor.Tag = "E3";
            armor.Click += SetEquip_Click;
            armor.Cursor = Cursors.Hand;
            layout.Controls.Add(armor);

            PictureBox boots = new PictureBox();
            boots.Location = new Point(20, 235);
            boots.Size = new Size(55, 55);
            boots.Image = listimage.Images[3];
            boots.SizeMode = PictureBoxSizeMode.StretchImage;
            boots.BorderStyle = BorderStyle.FixedSingle;
            boots.Tag = "E4";
            boots.Click += SetEquip_Click;
            boots.Cursor = Cursors.Hand;
            layout.Controls.Add(boots);

            PictureBox auxillary = new PictureBox();
            auxillary.Location = new Point(20, 300);
            auxillary.Size = new Size(55, 55);
            auxillary.Image = listimage.Images[4];
            auxillary.SizeMode = PictureBoxSizeMode.StretchImage;
            auxillary.BorderStyle = BorderStyle.FixedSingle;
            auxillary.Tag = "E5";
            auxillary.Click += SetEquip_Click;
            auxillary.Cursor = Cursors.Hand;
            layout.Controls.Add(auxillary);

            
            weapontxt.Location = new Point(80, 40);
            weapontxt.Size = new Size(200, 500);
            weapontxt.Font = new Font("Arial", 10, FontStyle.Bold);
            weapontxt.Text = "Weapon";
            weapontxt.ReadOnly = true;
            layout.Controls.Add(weapontxt);

            helmettxt.Location = new Point(80, 105);
            helmettxt.Size = new Size(200, 500);
            helmettxt.Font = new Font("Arial", 10, FontStyle.Bold);
            helmettxt.Text = "Helmet";
            helmettxt.ReadOnly = true;
            layout.Controls.Add(helmettxt);

            armortxt.Location = new Point(80, 170);
            armortxt.Size = new Size(200, 500);
            armortxt.Font = new Font("Arial", 10, FontStyle.Bold);
            armortxt.Text = "Armor";
            armortxt.ReadOnly = true;
            layout.Controls.Add(armortxt);

            bootstxt.Location = new Point(80, 235);
            bootstxt.Size = new Size(200, 500);
            bootstxt.Font = new Font("Arial", 10, FontStyle.Bold);
            bootstxt.Text = "Boots";
            bootstxt.ReadOnly = true;
            layout.Controls.Add(bootstxt);

            auxillarytxt.Location = new Point(80, 300);
            auxillarytxt.Size = new Size(200, 500);
            auxillarytxt.Font = new Font("Arial", 10, FontStyle.Bold);
            auxillarytxt.Text = "Auxillary";
            auxillarytxt.ReadOnly = true;
            layout.Controls.Add(auxillarytxt);


        }

        DataGridView dgvequipment = new DataGridView();


        private void SetEquip_Click(object sender, EventArgs e)
        {
            eq.Rows.Clear();
            PictureBox btn = sender as PictureBox;
            simpan = btn.Tag.ToString();
            sqlQuery = $"select id_equip as 'ID', eq_name as NAME from Equipment where id_equip like '%{btn.Tag}%';" ;
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(eq);
            dgvequipment.Location = new Point(300, 40);
            dgvequipment.DataSource = eq;
            //dgvequipment.Columns.Remove("ID");
            layout.Controls.Add(dgvequipment);
            dgvequipment.CellClick += Dgvequipment_CellClick;
            menu = int.Parse(btn.Tag.ToString().Substring(1))-1;

           

        }
        string simpan = "";
        int menu = 0;
        string id_pass = "";
        Label desc = new Label();
        Label lvl = new Label();
        string daftarkata = "";
        private void Dgvequipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(menu.ToString());
            desc.Text = "";
            eqdesc.Rows.Clear();

            id_pass = eq.Rows[e.RowIndex][0].ToString();

            sqlQuery = $"select eq_desc as description, eq_level as level from Equipment where id_equip = '{id_pass}'";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(eqdesc);
            desc.Size = new Size(250,20);
            desc.Text = "Description : " + eqdesc.Rows[0][0].ToString();
            desc.Font = new Font("Montserrat", 9, FontStyle.Bold);
            desc.Location = new Point(300, 220);
            lvl.Size = new Size(250, 50);
            lvl.Text = "Lvl : " + eqdesc.Rows[0][1].ToString();
            lvl.Font = new Font("Montserrat", 8, FontStyle.Bold);
            lvl.Location = new Point(300, 240);
            layout.Controls.Add(desc);
            layout.Controls.Add(lvl);
            DataTable sv = new DataTable();
            if(menu == 0)
            {
                sqlQuery = $"select eq_name from Equipment where id_equip = '{id_pass}';";
                cmd = new MySqlCommand(sqlQuery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(sv);
                eqname[0] = sv.Rows[0][0].ToString();
                weapontxt.Text = eqname[0];
            }
            if (menu == 1)
            {
                sqlQuery = $"select eq_name from Equipment where id_equip = '{id_pass}';";
                cmd = new MySqlCommand(sqlQuery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(sv);
                eqname[1] = sv.Rows[0][0].ToString();
                helmettxt.Text = eqname[1];
            }
            if (menu == 2)
            {
                sqlQuery = $"select eq_name from Equipment where id_equip = '{id_pass}';";
                cmd = new MySqlCommand(sqlQuery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(sv);
                eqname[2] = sv.Rows[0][0].ToString();
                armortxt.Text = eqname[2];
            }
            if (menu == 3)
            {
                sqlQuery = $"select eq_name from Equipment where id_equip = '{id_pass}';";
                cmd = new MySqlCommand(sqlQuery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(sv);
                eqname[3] = sv.Rows[0][0].ToString();
                bootstxt.Text = eqname[3];
            }
            if (menu == 4)
            {
                sqlQuery = $"select eq_name from Equipment where id_equip = '{id_pass}';";
                cmd = new MySqlCommand(sqlQuery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(sv);
                eqname[4] = sv.Rows[0][0].ToString();
                bootstxt.Text = eqname[4];
            }
            daftarkata = "";
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)

                {
                    daftarkata += "'" + eqname[i].ToString() + "'";
                }
                else
                {
                    daftarkata += "'" + eqname[i].ToString() + "',";
                }

            }
            eq.Rows.Clear();
            PictureBox btn = sender as PictureBox;
            sqlQuery = $"select id_equip as 'ID', eq_name as NAME from Equipment where id_equip like '%{simpan}%' and eq_name not in ({daftarkata});";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(eq);
            dgvequipment.DataSource = eq;

        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }


        private void btnback_Click(object sender, EventArgs e)
        {
            layout.Controls.Clear();
            weapontxt.Text = "Weapon";
            helmettxt.Text = "Helmet";
            armortxt.Text = "Armor";
            bootstxt.Text = "Boots";
            auxillarytxt.Text = "Auxillary";

        }
    }
}
