namespace ButtonMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    {
                        this.Top -= 10;
                        break;
                    }
                case Keys.Down:
                    {
                        this.Top += 10;
                        break;
                    }
                case Keys.Left:
                    {
                        this.Left -= 10;
                        break;
                    }
                case Keys.Right:
                    {
                        this.Left += 10;
                        break;
                    }
                case Keys.W:
                    {
                        if(button1.Top > 10)
                        button1.Top -= 10;
                        break;
                    }
                case Keys.S:
                    {
                        if (button1.Top < this.Height - button1.Size.Height - 50)
                        {
                            button1.Top += 10;
                        }
                        break;
                    }
                case Keys.A:
                    {
                        if (this.button1.Left > 10)
                        button1.Left -= 10;
                        
                        break;
                    }
                case Keys.D:
                    {
                        if(this.button1.Left < this.Width - button1.Size.Width - 30)
                        button1.Left += 10;
                        break;
                    }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
