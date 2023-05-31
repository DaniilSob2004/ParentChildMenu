namespace ParentChildMenu
{
    public partial class Child : Form
    {
        private Parent parent;

        public Child()
        {
            InitializeComponent();
        }

        public Child(Parent parent) : this()  // делегирование
        {
            this.parent = parent;  // сохраняем родителя
        }

        public void ChangeTextBox(string text)
        {
            childTextBox.Text = text;  // меняем текст
        }

        private void ChildTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // меняем текст у родителя
            parent.ChangeTextBox(childTextBox.Text);
        }

        private void Child_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.CloseChild();
        }
    }
}
