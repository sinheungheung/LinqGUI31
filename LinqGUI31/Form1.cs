using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUI31
{
    public partial class Form1 : Form
    {
        static private List<Food> foodList = new List<Food>
        {
            new Food() {Name="짜장면", Price=8000},
            new Food() {Name="햄버거", Price=9000},
            new Food() {Name="탕수육", Price=15000},
            new Food() {Name="껌", Price=1000},
            new Food() {Name="탕후루", Price=2000}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // list의 내용을 DataGridSource에 넣어줘서 모두 출력되게 함
            foodBindingSource.DataSource = foodList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 두번째 버튼의 클릭 이벤트 핸들러 메서드를 만들고 Linq를 사용하여 1500원 이상의 가격을 가진 음식을 비싼 순서대로 나오게 함
            foodBindingSource.DataSource = (from item in foodList
                                            where item.Price >= 1500
                                            orderby item.Price descending
                                            select item).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 이를 내림차순으로 나타나게 함
            foodBindingSource.DataSource = (from item in foodList
                                            orderby item.Name descending
                                            select item).ToList();
        }
    }
}
