using System.IO;
using System.Diagnostics;

using Microsoft.VisualBasic;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private string filePath = "D:";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        // private string errorMessage = string.Empty;

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
            string tempFilePath = "";
            FileAttributes fileAttributes;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLbl.Text = $"{fileDetails.Name} ff";
                    fileTypeLbl.Text = fileDetails.Extension;
                    fileAttributes = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttributes = File.GetAttributes(filePath);



                }
                if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();  // GET ALL THE FILES
                    DirectoryInfo[] directories = fileList.GetDirectories();    // GET ALL THE DIRECTORIES
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < directories.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch(fileExtension)
                        {
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 7);
                                break;
                            case ".TXT":
                            case ".DOCX":
                            case ".DOC":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".MP3":
                                listView1.Items.Add(files[i].Name, 0);
                                break ;
                            case ".MP4":
                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            default:
                        listView1.Items.Add(files[i].Name, 7);
                                break;
                        }
                        goto directoriesGetListOperation;
                    }
                directoriesGetListOperation:
                    for (int i = 0; i < directories.Length; i++)
                    {
                        listView1.Items.Add(directories[i].Name, 8);
                    }
                }
                else
                {
                    fileNameLbl.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            {

            }

        }

        public void LoadButtonAction()
        {
            RemoveBackSlash();
            filePath = filePathTxt.Text;
            LoadFilesAndDirectories();
            isFile = false;
        }

        public void RemoveBackSlash()
        {
            string path = filePathTxt.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTxt.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void GoBack()
        {
            try
            {
                string path = filePathTxt.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTxt.Text = path;
                RemoveBackSlash();
            }
            catch
            {
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            LoadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttributes = File.GetAttributes(filePath + "/" + currentlySelectedItemName);

            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTxt.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            LoadButtonAction();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            GoBack();
            LoadButtonAction();
        }
    }
}
