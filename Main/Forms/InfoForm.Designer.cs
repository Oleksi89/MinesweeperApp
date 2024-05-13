namespace Main.Forms
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.Font = new Font("AniMe Matrix - MB_EN", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Instructions  and  rules", "", "Here  are  some  useful  tips:", "", "          To  start  the  game  again,  click  on  the  yellow  smiley  face.", "          To  reveal  the  cell  press  the  left  mouse  button  on  it", "          To  flag  a  cell  as  a  suspected  mine,  press  the  right  mouse  button  on  it.", "          The  goal  of  the  game  is  to  open  all  the  cells  that  do  not  contain  mines.", "  It  is  not  necessary  to  place  flags!", "          You  can  change  game  settings  in  the  settings  menu.", "          ", "", "Here's  how  the  settings  available  in  the  game  work:", "", "          1.  Safe  start.  The  first  time  you  click  on  any  cell,  that  cell  will  always  ", "be  empty  and  a  large  zone  will  open.  If  this  setting  is  disabled,  the  playing", "  field  is  formed  completely  randomly,  so  on  the  first  click  there  may  be", "  a  number  or  even  a  mine!", "          2.  Safe  zone.  If  you  click  on  the  number  displaying  the  number  of  ", "surrounding  mines  marked  with  flags,  the  remaining  adjacent  cells  ", "will  open.  If  this  setting  is  disabled,  clicking  on  a  number  will  do  nothing.", "          3.  Revealing  the  remaining  ones.  If  you  find  all  the  mines  and  mark  ", "them  with  flags,  and  the  remaining  mines  indicator  shows  \"000\",", "  you  can  click  on  it  and  all  the  remaining  cells  will  open.", "          4.  Neutralization.  If  you  click  on  the  mine,  you  won`t  loose.  If  this ", " setting  is  disabled,  you  simply  die  outright." });
            listBox1.Location = new Point(31, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(746, 394);
            listBox1.TabIndex = 0;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}