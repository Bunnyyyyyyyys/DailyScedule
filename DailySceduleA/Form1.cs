using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyScheduleApp
{

    public partial class Form1 : Form
    {
        public List<TaskItem> tasks; // Список задач
        public Form1()
        {
            InitializeComponent();
            tasks = new List<TaskItem>(); // Инициализируем список задач
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            string taskText = textBoxTask.Text.Trim();

            if (!string.IsNullOrEmpty(taskText))
            {
                TaskItem newTask = new TaskItem(taskText); // Создаем новую задачу
                tasks.Add(newTask); // Добавляем задачу в список

                // Обновляем список задач на форме
                RefreshTaskList();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите задачу.");
            }
        }

        public void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSchedule.SelectedIndex != -1)
            {
                // Удаляем задачу из списка
                tasks.RemoveAt(listBoxSchedule.SelectedIndex);

                // Обновляем список задач на форме
                RefreshTaskList();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите задачу для удаления.");
            }
        }

        public void RefreshTaskList()
        {
            listBoxSchedule.Items.Clear();
            foreach (TaskItem task in tasks)
            {
                listBoxSchedule.Items.Add(task.Text);
            }
        }

        public void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        public void listBoxSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    // Класс для представления задачи
    public class TaskItem
    {
        public string Text { get; set; }

        public TaskItem(string text)
        {
            Text = text;
        }
    }
}
