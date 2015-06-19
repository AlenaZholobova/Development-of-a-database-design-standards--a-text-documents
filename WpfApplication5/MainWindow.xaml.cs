using System;
using Fluent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private List<Class1> dataTable;
        private SortedDictionary<string, List<int>> tags;
        public MainWindow()
        {
            InitializeComponent();
            if (BazaDannyh() == false) Close();
            TextFile();
            BazaTagov();
            NMg();
        }
      
        private void NMg()
        {
            Tags.Items.Clear();
            foreach (string tag in tags.Keys)
            {
                Tags.Items.Add(tag);
            }
            Tags.SelectedIndex = 0;

        }

        private void Table1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Table1.SelectedItem != null)
            {
                Class1 t = Table1.SelectedItem as Class1;
                //проверка на существование файла или пути к нему
                if (System.IO.File.Exists(t.s))
                {
                    wrt.Source = new Uri("file:///" + t.s);
                }
                else MessageBox.Show("Файл не найден по следующему пути:\n" + t.s);
            }
        }
        public bool BazaDannyh()
        {
            string file = "list.txt";
            try
            {
                System.IO.StreamReader fobj = new System.IO.StreamReader(file);
                List<string> lstbox = new List<string>();
                dataTable = new List<Class1>();
                while (fobj.EndOfStream == false)
                {
                    string s = fobj.ReadLine();
                    string[] sm = s.Split('\t');
                    int id = Convert.ToInt32(sm[0]);
                    Class1 eobj = new Class1(id, sm[1], sm[2], Convert.ToInt32(sm[3]), null);
                    eobj.s = sm[4];
                    eobj.s= Environment.CurrentDirectory +"\\" + sm[4];
                    dataTable.Add(eobj);
                }
                fobj.Close();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool TextFile()
        {
            string file = "TextFile1.txt";
            try
            {
                System.IO.StreamReader baza = new System.IO.StreamReader(file);
                while (baza.EndOfStream == false)
                {
                    string s = baza.ReadLine();
                    string[] sm = s.Split('\t');
                    int id = Convert.ToInt32(sm[0]);
                    List<string> lstoftag = new List<string>(sm[1].Split(';'));
                    for (int i = 0; i < dataTable.Count; i++)
                    {
                        if (dataTable[i].id == id)
                        {
                            dataTable[i].тег = lstoftag;
                            break;
                        }
                    }                
                }
                baza.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool BazaTagov()
        {
            tags = new SortedDictionary<string, List<int>>();
            for (int i = 0; i < dataTable.Count; i++)
            {
                List<string> arr = dataTable[i].тег;
                foreach (string s in arr)
                {
                    if (tags.ContainsKey(s))
                    {
                        tags[s].Add(dataTable[i].id);
                    }
                    else
                    {
                        List<int> o = new List<int>();
                        o.Add(dataTable[i].id);
                        tags.Add(s, o);
                    }
                }
            }
            return true;
        }

        private void BackstageTabItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Tags_DropDownClosed(object sender, EventArgs e)
        {
            List<Class1> lts = new List<Class1>();
            string str = Tags.Text;
            Table1.Items.Clear();
            if (str.Equals(""))
            {
                foreach (Class1 c in dataTable)
                {
                    Table1.Items.Add(c);
                }
            }
            else
            {
                List<int> irows = tags[str];
                foreach (int i in irows)
                {

                    for (int j = 0; j < dataTable.Count; j++)
                    {
                        if (dataTable[j].id == i)
                        {
                            Table1.Items.Add(dataTable[j]);
                            break;
                        }
                    }
                }
            }
         }   
       }
    }


