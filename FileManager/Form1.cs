using System.IO;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private string filePath = "C:";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTxt.Text = filePath;
            LoadFilesAndDerictories();
        }

        public void LoadFilesAndDerictories()
        {
            DirectoryInfo fileList;
            try
            {
                fileList = new DirectoryInfo(filePath);
                FileInfo[] files = fileList.GetFiles();  // GET ALL THE FILES
                DirectoryInfo[] derictories = fileList.GetDirectories();    // GET ALL THE DERICTORIES
                for(int =0 )
            }
            catch (Exception e)
            {

            }
        }

        public void LoadButtonAction()
        {
            filePath = filePathTxt.Text;
            LoadFilesAndDerictories();
            isFile = false;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            LoadButtonAction();
        }

        private void listView1_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
        }
    }
}
