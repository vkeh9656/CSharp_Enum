using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strName = "";

        private enum enumDay    // 문자열 같아보이지만, 실제로는 숫자형으로 컴파일러가 인식함. 문자는 껍데기일뿐
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday.ToString());
            lboxDay.Items.Add(enumDay.Wednesday.ToString());
            lboxDay.Items.Add(enumDay.Thursday.ToString());
            lboxDay.Items.Add(enumDay.Friday.ToString());
            lboxDay.Items.Add(enumDay.Saturday.ToString());
            lboxDay.Items.Add(enumDay.Sunday.ToString());

            lboxTime.Items.Add(enumTime.Morning.ToString());
            lboxTime.Items.Add(enumTime.Afternoon.ToString());
            lboxTime.Items.Add(enumTime.Evening.ToString());
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 준호와 Monday(요일) Afternoon에 보기로 했습니다.
            string strResult = tboxName.Text + "와 " + lboxDay.SelectedItem.ToString() + "(요일) " +
                lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";

            tboxResult.Text = strResult;
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            string strResult = String.Format("{0}와 {1}(요일) {2}에 보기로 했습니다.",
                                                      tboxName.Text, 
                                                      lboxDay.SelectedItem.ToString(), 
                                                      lboxTime.SelectedItem.ToString());

            tboxResult.Text = strResult;
        }
    }
}
