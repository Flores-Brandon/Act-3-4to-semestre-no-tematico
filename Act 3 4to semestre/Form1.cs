using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para trabajar con DataTable (para CSV)
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; // Para trabajar con JSON
using System.Xml;
using System.IO; // Para trabajar con XML
using Newtonsoft.Json.Linq;

namespace Act_3_4to_semestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Leer el archivo CSV
                DataTable dataTable = new DataTable();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string[] headers = reader.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine().Split(',');
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            row[i] = rows[i];
                        }
                        dataTable.Rows.Add(row);
                    }
                }

                // Hacer lo que necesites con los datos, por ejemplo, mostrarlos en un DataGridView
                dataGridView.DataSource = dataTable;
            }

        }

        private void btnXJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (filePath.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    // Lógica para el procesamiento de archivos XML
                    ProcessXML(filePath);
                }
                else if (filePath.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    // Lógica para el procesamiento de archivos JSON
                    ProcessJSON(filePath);
                }
            }
        }
        private void ProcessXML(string filePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                DataTable dataTable = new DataTable();

                // Obtener los encabezados dinámicamente
                XmlNodeList headers = xmlDoc.DocumentElement.ChildNodes[0].ChildNodes;
                foreach (XmlNode headerNode in headers)
                {
                    dataTable.Columns.Add(headerNode.Name);
                }

                // Agregar filas al DataTable
                foreach (XmlNode rowNode in xmlDoc.DocumentElement.ChildNodes)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (XmlNode cellNode in rowNode.ChildNodes)
                    {
                        row[cellNode.Name] = cellNode.InnerText;
                    }
                    dataTable.Rows.Add(row);
                }

                // Mostrar datos en el DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo XML: {ex.Message}");
            }
        }

        private void ProcessJSON(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);

                DataTable dataTable = new DataTable();

                // Obtener los encabezados dinámicamente
                JObject jsonObj = JObject.Parse(jsonContent);
                var propertyNames = jsonObj.Properties().Select(p => p.Name).ToList();
                foreach (string propertyName in propertyNames)
                {
                    dataTable.Columns.Add(propertyName);
                }

                // Agregar filas al DataTable
                DataRow row = dataTable.NewRow();
                foreach (var property in jsonObj.Properties())
                {
                    row[property.Name] = property.Value.ToString();
                }
                dataTable.Rows.Add(row);

                // Mostrar datos en el DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo JSON: {ex.Message}");
            }
        }

        private void btnNoEstructurados_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Procesamiento de archivos no estructurados, como archivos de texto
                string fileContent = File.ReadAllText(openFileDialog.FileName);
                // Hacer lo que necesites con el contenido del archivo
            }
        }
    }
}
