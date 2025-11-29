using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Xml.Linq;
using System;
using System.IO;
using System.Windows.Forms;


namespace coffeeshop
{
    public partial class Form1 : Form
    {
        private BindingList<Kostomer> _kostomer = new BindingList<Kostomer>();
        private readonly string _filePath = "coffeeshop_thejson.json";

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var kostomer = new Kostomer
            {
                Name = textBox1.Text,
                Coffee = comboBox1.SelectedItem?.ToString(),
                SugarLevel = comboBox2.SelectedItem?.ToString()
            };

            _kostomer.Add(kostomer);
            SaveData();

            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var kostomer = dataGridView1.CurrentRow.DataBoundItem as Kostomer;

            if (kostomer != null) {

                textBox1.Text = kostomer.Name;
                comboBox1.SelectedItem = kostomer.Coffee;
                comboBox2.SelectedItem = kostomer.SugarLevel;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var kostomer = dataGridView1.CurrentRow.DataBoundItem as Kostomer;

            if (kostomer != null)
            {
                _kostomer.Remove(kostomer);
                SaveData();

                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;

            }

        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                var list = JsonSerializer.Deserialize<List<Kostomer>>(json) ?? new List<Kostomer>();
                _kostomer = new BindingList<Kostomer>(list);
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _kostomer;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void SaveData()
        {

            string json = JsonSerializer.Serialize(_kostomer.ToList(), new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var kostomer = dataGridView1.CurrentRow.DataBoundItem as Kostomer;
            if (kostomer != null) {

                textBox1.Text = kostomer.Name;
                comboBox1.SelectedItem = kostomer.Coffee;
                comboBox2.SelectedItem = kostomer.SugarLevel;
            }
        }

        private void akoNigah(){

        Console.WriteLine("Kyle Gamay ug Otin");
        }
    }
}
