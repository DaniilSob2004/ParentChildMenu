namespace ParentChildMenu
{
    public partial class Parent : Form
    {
        private Child child;

        public Parent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            CreateChild();
        }

        public void ChangeTextBox(string text)
        {
            parentTextBox.Text = text;  // меняем текст
        }

        public void CloseChild()
        {
            child = null;
        }

        private void CreateChild()
        {
            // создаём доп. окно, и передаём в конструктор родителя
            child = new Child(this);
            child.Show();
        }

        private void ParentTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (child != null)
                child.ChangeTextBox(parentTextBox.Text);  // меняем текст у ребёнка
        }
    }
}