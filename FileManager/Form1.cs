//using System.IO;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private string filePath = "D:";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTxt.Text = filePath;
            LoadFilesAndDirectories();
        }

        public void LoadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            fileList = new DirectoryInfo(filePath);
            FileInfo[] files = fileList.GetFiles();  // GET ALL THE FILES
            DirectoryInfo[] directories = fileList.GetDirectories();    // GET ALL THE DIRECTORIES
            try
            {

                for (int i = 0; i < directories.Length; i++)
                {
                    listView1.Items.Add(files[i].Name);
                }
            }
            catch (Exception e)
            {
            }

            try
            {
                for (int i = 0; i < directories.Length; i++)
                {
                    listView1.Items.Add(directories[i].Name);
                }
            }
            catch (Exception e)
            {
            }

        }

        public void LoadButtonAction()
        {
            filePath = filePathTxt.Text;
            LoadFilesAndDirectories();
            isFile = false;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            LoadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttributes = File.GetAttributes(currentlySelectedItemName);

            if((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTxt.Text = currentlySelectedItemName;
            }
            else
            {
                isFile = true; 
            }
        }
    }
}
