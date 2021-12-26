using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlansetUjebnik;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using SpannedDataGridViewNet2;
using System.Collections;

namespace Material_Route
{
    static class Table
    {
        private static string query;
        //Formulation kvart  = new Formulation();

        public static void GridSSI(DataGridView grid, string s, string id, System.Data.DataTable dt)
        {
            ClassBD cbd = new ClassBD();
            switch (s)
            {
                case "snsh":
                    {
                        //MessageBox.Show(id);
                     
                        grid.DataSource = dt;
                        grid.AutoGenerateColumns = true;

                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "Чертежный № (цифровой)";
                        grid.Columns[0].FillWeight = 60;
                        grid.Columns[1].HeaderText = "Наименование";
                        grid.Columns[1].FillWeight = 60;
                    }
                    break;
                case "snrb":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;
                       
                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "Чертежный № (цифровой)";
                        grid.Columns[0].FillWeight = 60;
                        grid.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
                        grid.Columns[1].HeaderText = "Наименование";
                        grid.Columns[1].FillWeight = 60;
                        grid.Columns[1].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    break;
                case "rb":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;
                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[1].HeaderText = "Цех";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[2].HeaderText = "Наименование Технологической Операции";
                        grid.Columns[2].FillWeight = 100;
                        grid.Columns[3].HeaderText = "Наименование Материала";
                        grid.Columns[3].FillWeight = 150;
                        grid.Columns[4].HeaderText = "чертежный № (детали)";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "Код входящего компонента";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "Год";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[7].HeaderText = "№ позиции";
                        grid.Columns[7].FillWeight = 30;
                        grid.Columns[8].HeaderText = "Код единици измерения";
                        grid.Columns[8].FillWeight = 30;
                        grid.Columns[9].HeaderText = "% ВГ 1 квартал";
                        grid.Columns[9].FillWeight = 30;
                        grid.Columns[10].HeaderText = "% ВГ 2 квартал";
                        grid.Columns[10].FillWeight = 30;
                        grid.Columns[11].HeaderText = "% ВГ 3 квартал";
                        grid.Columns[11].FillWeight = 30;
                        grid.Columns[12].HeaderText = "% ВГ 4 квартал";
                        grid.Columns[12].FillWeight = 30;
                        grid.Columns[13].HeaderText = "Коэфициент запуска1";
                        grid.Columns[13].FillWeight = 30;
                        grid.Columns[14].HeaderText = "Коэфициент запуска2";
                        grid.Columns[14].FillWeight = 30;
                        grid.Columns[15].HeaderText = "Коэфициент запуска3";
                        grid.Columns[15].FillWeight = 30;
                        grid.Columns[16].HeaderText = "Коэфициент запуска4";
                        grid.Columns[16].FillWeight = 30;
                        grid.Columns[17].HeaderText = "Технологическая Норма";
                        grid.Columns[17].FillWeight = 30;
                        grid.Columns[17].DefaultCellStyle.Format = "N6";
                        grid.Columns[18].HeaderText = "Технологическая расчетная Норма";
                        grid.Columns[18].FillWeight = 30;
                        grid.Columns[18].DefaultCellStyle.Format = "N6";
                        grid.Columns[19].HeaderText = "id";
                        grid.Columns[19].FillWeight = 30;


                        grid.Columns[1].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[19].Visible = false;

                        for (int i = 0; i < 9; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                        for (int i = 13; i < 17; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                        grid.Columns[18].ReadOnly = true; grid.Columns[18].DefaultCellStyle.BackColor = Color.LightGray;

                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    }
                    break;
                case "pric":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;
                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[1].HeaderText = "Цех";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[2].HeaderText = "Наименование Технологической Операции";
                        grid.Columns[2].FillWeight = 100;
                        grid.Columns[3].HeaderText = "Наименование Материала";
                        grid.Columns[3].FillWeight = 150;
                        grid.Columns[4].HeaderText = "чертежный № (детали)";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "Код входящего компонента";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "Год";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[7].HeaderText = "№ позиции";
                        grid.Columns[7].FillWeight = 30;
                        grid.Columns[8].HeaderText = "Код единици измерения";
                        grid.Columns[8].FillWeight = 30;
                       
                        grid.Columns[9].HeaderText = "Технологическая Норма";
                        grid.Columns[9].FillWeight = 30;
                        grid.Columns[9].DefaultCellStyle.Format = "N6";
                        grid.Columns[10].HeaderText = "Технологическая расчетная Норма";
                        grid.Columns[10].FillWeight = 30;
                        grid.Columns[10].DefaultCellStyle.Format = "N6";
                        grid.Columns[11].HeaderText = "Цена";
                        grid.Columns[11].FillWeight = 30;
                        grid.Columns[11].DefaultCellStyle.Format = "N2";
                        
                        grid.Columns[12].HeaderText = "id";
                        grid.Columns[12].FillWeight = 30;


                        grid.Columns[1].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[12].Visible = false;

                        for (int i = 0; i < 11; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                        
                       // grid.Columns[18].ReadOnly = true; grid.Columns[18].DefaultCellStyle.BackColor = Color.LightGray;

                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    }
                    break;
                case "rb1":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;
                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "№ Детали вх. 1";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[0].ValueType = typeof(DataGridViewTextBoxColumnEx);
                        grid.Columns[1].HeaderText = "№ Детали вх. 2";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[1].ValueType = typeof(DataGridViewTextBoxColumnEx);
                        grid.Columns[2].HeaderText = "№ Детали вх. 3";
                        grid.Columns[2].FillWeight = 30;
                        grid.Columns[3].HeaderText = "№ Детали вх. 4";
                        grid.Columns[3].FillWeight = 30;
                        grid.Columns[4].HeaderText = "№ Детали вх. 5";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "№ Детали вх. 6";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "№ Детали вх. 7";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[7].HeaderText = "№ Детали вх. 8";
                        grid.Columns[7].FillWeight = 30;
                        grid.Columns[8].HeaderText = "№ Детали вх. 9";
                        grid.Columns[8].FillWeight = 30;
                        grid.Columns[9].HeaderText = "№ Детали вх. 10";
                        grid.Columns[9].FillWeight = 30;
                       
                        grid.Columns[10].HeaderText = "id";
                        grid.Columns[10].FillWeight = 30;

                        grid.Columns[10].Visible = false;

                       // for (int i = 0; i < 9; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                       // for (int i = 13; i < 17; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                       // grid.Columns[18].ReadOnly = true; grid.Columns[18].DefaultCellStyle.BackColor = Color.LightGray;
                        grid.ReadOnly = true;
                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    }
                    break;
                case "shab":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;

                        grid.AutoGenerateColumns = true;

                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 25;
                        grid.Columns[1].HeaderText = "Цех";
                        grid.Columns[1].FillWeight = 25;
                        grid.Columns[2].HeaderText = "Наименование Технологической Операции";
                        grid.Columns[2].FillWeight = 100;
                        grid.Columns[3].HeaderText = "Наименование Материала";
                        grid.Columns[3].FillWeight = 150;
                        grid.Columns[4].HeaderText = "чертежный № (детали)";
                        grid.Columns[4].FillWeight = 35;
                        grid.Columns[5].HeaderText = "Норма";
                        grid.Columns[5].FillWeight = 35;
                        grid.Columns[5].DefaultCellStyle.Format = "N6";
                        grid.Columns[6].HeaderText = "Код материала";
                        grid.Columns[6].FillWeight = 35;
                        grid.Columns[7].HeaderText = "Цена";
                        grid.Columns[7].FillWeight = 30;
                        grid.Columns[7].DefaultCellStyle.Format = "N2";
                    }
                    break;
                case "shab1":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;

                        grid.AutoGenerateColumns = true;

                        grid.Columns[0].HeaderText = "№ Детали";
                        grid.Columns[0].FillWeight = 45;
                        grid.Columns[1].HeaderText = "Операция";
                        grid.Columns[1].FillWeight = 25;
                        grid.Columns[2].HeaderText = "Позиция";
                        grid.Columns[2].FillWeight = 25;
                        
                        grid.Columns[3].HeaderText = "Материал";
                        grid.Columns[3].FillWeight = 200;
                        grid.Columns[4].HeaderText = "Код ед. изм.";
                        grid.Columns[4].FillWeight = 35;
                        grid.Columns[5].HeaderText = "Норма";
                        grid.Columns[5].FillWeight = 35;
                        grid.Columns[5].DefaultCellStyle.Format = "N6";
                       
                        grid.Columns[6].HeaderText = "Цена";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[6].DefaultCellStyle.Format = "N2";
                        grid.Columns[7].HeaderText = "Код материала";
                        grid.Columns[7].FillWeight = 35;
                         
                    }
                    break;
                case "opn":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;

                        grid.AutoGenerateColumns = true;

                        grid.Columns[0].HeaderText = "Д. вх. 1";
                        grid.Columns[0].FillWeight = 45;
                        grid.Columns[1].HeaderText = "О. вх. 1";
                        grid.Columns[1].FillWeight = 15;
                        grid.Columns[2].HeaderText = "П. вх. 1";
                        grid.Columns[2].FillWeight = 15;
                        grid.Columns[3].HeaderText = "Н. вх. 1";
                        grid.Columns[3].FillWeight = 25;
                        grid.Columns[3].DefaultCellStyle.Format = "N6";

                        grid.Columns[4].HeaderText = "Д. вх. 2";
                        grid.Columns[4].FillWeight = 45;
                        grid.Columns[5].HeaderText = "О. вх. 2";
                        grid.Columns[5].FillWeight = 15;
                        grid.Columns[6].HeaderText = "П. вх. 2";
                        grid.Columns[6].FillWeight = 15;
                        grid.Columns[7].HeaderText = "Н. вх. 2";
                        grid.Columns[7].FillWeight = 25;
                        grid.Columns[7].DefaultCellStyle.Format = "N6";

                        grid.Columns[8].HeaderText = "Д. вх. 3";
                        grid.Columns[8].FillWeight = 45;
                        grid.Columns[9].HeaderText = "О. вх. 3";
                        grid.Columns[9].FillWeight = 15;
                        grid.Columns[10].HeaderText = "П. вх. 3";
                        grid.Columns[10].FillWeight = 15;
                        grid.Columns[11].HeaderText = "Н. вх. 3";
                        grid.Columns[11].FillWeight = 25;
                        grid.Columns[11].DefaultCellStyle.Format = "N6";

                        grid.Columns[12].HeaderText = "Д. вх. 4";
                        grid.Columns[12].FillWeight = 45;
                        grid.Columns[13].HeaderText = "О. вх. 4";
                        grid.Columns[13].FillWeight = 15;
                        grid.Columns[14].HeaderText = "П. вх. 4";
                        grid.Columns[14].FillWeight = 15;
                        grid.Columns[15].HeaderText = "Н. вх. 4";
                        grid.Columns[15].FillWeight = 25;
                        grid.Columns[15].DefaultCellStyle.Format = "N6";

                        grid.Columns[16].HeaderText = "Д. вх. 5";
                        grid.Columns[16].FillWeight = 45;
                        grid.Columns[17].HeaderText = "О. вх. 5";
                        grid.Columns[17].FillWeight = 15;
                        grid.Columns[18].HeaderText = "П. вх. 5";
                        grid.Columns[18].FillWeight = 15;
                        grid.Columns[19].HeaderText = "Н. вх. 5";
                        grid.Columns[19].FillWeight = 25;
                        grid.Columns[19].DefaultCellStyle.Format = "N6";

                        grid.Columns[20].HeaderText = "Д. вх. 6";
                        grid.Columns[20].FillWeight = 45;
                        grid.Columns[21].HeaderText = "О. вх. 6";
                        grid.Columns[21].FillWeight = 15;
                        grid.Columns[22].HeaderText = "П. вх. 6";
                        grid.Columns[22].FillWeight = 15;
                        grid.Columns[23].HeaderText = "Н. вх. 6";
                        grid.Columns[23].FillWeight = 25;
                        grid.Columns[23].DefaultCellStyle.Format = "N6";

                        grid.Columns[24].HeaderText = "Д. вх. 7";
                        grid.Columns[24].FillWeight = 45;
                        grid.Columns[25].HeaderText = "О. вх. 7";
                        grid.Columns[25].FillWeight = 15;
                        grid.Columns[26].HeaderText = "П. вх. 7";
                        grid.Columns[26].FillWeight = 15;
                        grid.Columns[27].HeaderText = "Н. вх. 7";
                        grid.Columns[27].FillWeight = 25;
                        grid.Columns[27].DefaultCellStyle.Format = "N6";

                        grid.Columns[28].HeaderText = "Д. вх. 8";
                        grid.Columns[28].FillWeight = 45;
                        grid.Columns[29].HeaderText = "О. вх. 8";
                        grid.Columns[29].FillWeight = 15;
                        grid.Columns[30].HeaderText = "П. вх. 8";
                        grid.Columns[30].FillWeight = 15;
                        grid.Columns[31].HeaderText = "Н. вх. 8";
                        grid.Columns[31].FillWeight = 25;
                        grid.Columns[31].DefaultCellStyle.Format = "N6";

                        grid.Columns[32].HeaderText = "Д. вх. 9";
                        grid.Columns[32].FillWeight = 45;
                        grid.Columns[33].HeaderText = "О. вх. 9";
                        grid.Columns[33].FillWeight = 15;
                        grid.Columns[34].HeaderText = "П. вх. 9";
                        grid.Columns[34].FillWeight = 15;
                        grid.Columns[35].HeaderText = "Н. вх. 9";
                        grid.Columns[35].FillWeight = 25;
                        grid.Columns[35].DefaultCellStyle.Format = "N6";

                        grid.Columns[36].HeaderText = "Д. вх. 10";
                        grid.Columns[36].FillWeight = 45;
                        grid.Columns[37].HeaderText = "О. вх. 10";
                        grid.Columns[37].FillWeight = 15;
                        grid.Columns[38].HeaderText = "П. вх. 10";
                        grid.Columns[38].FillWeight = 15;
                        grid.Columns[39].HeaderText = "Н. вх. 10";
                        grid.Columns[39].FillWeight = 25;
                        grid.Columns[39].DefaultCellStyle.Format = "N6";

                        //grid.Columns[40].HeaderText = "id";
                        //grid.Columns[40].FillWeight = 30;

                        //grid.Columns[40].Visible = false;
                    }
                    break;
                case "wmm":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;

                        grid.AutoGenerateColumns = true;

                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 25;
                        grid.Columns[1].HeaderText = "Цех";
                        grid.Columns[1].FillWeight = 20;
                        grid.Columns[2].HeaderText = "Наименование Технологической Операции";
                        grid.Columns[2].FillWeight = 100;
                        grid.Columns[3].HeaderText = "Наименование Материала";
                        grid.Columns[3].FillWeight = 115;
                        grid.Columns[4].HeaderText = "чертежный № (детали)";
                        grid.Columns[4].FillWeight = 35;
                        grid.Columns[5].HeaderText = "Код входящего компонента";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "Год";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[7].HeaderText = "№ позиции";
                        grid.Columns[7].FillWeight = 20;
                        grid.Columns[8].HeaderText = "Код единици измерения";
                        grid.Columns[8].FillWeight = 35;
                        grid.Columns[9].HeaderText = "% ВГ 1 квартал";
                        grid.Columns[9].FillWeight = 35;
                        grid.Columns[10].HeaderText = "% ВГ 2 квартал";
                        grid.Columns[10].FillWeight = 35;
                        grid.Columns[11].HeaderText = "% ВГ 3 квартал";
                        grid.Columns[11].FillWeight = 35;
                        grid.Columns[12].HeaderText = "% ВГ 4 квартал";
                        grid.Columns[12].FillWeight = 35;
                        grid.Columns[13].HeaderText = "Коэфициент запуска1";
                        grid.Columns[13].FillWeight = 30;
                        grid.Columns[14].HeaderText = "Коэфициент запуска2";
                        grid.Columns[14].FillWeight = 35;
                        grid.Columns[15].HeaderText = "Коэфициент запуска3";
                        grid.Columns[15].FillWeight = 35;
                        grid.Columns[16].HeaderText = "Коэфициент запуска4";
                        grid.Columns[16].FillWeight = 35;
                        grid.Columns[17].HeaderText = "Техно-ческая Норма";
                        grid.Columns[17].FillWeight = 35;
                        grid.Columns[17].DefaultCellStyle.Format = "N6";
                        grid.Columns[18].HeaderText = "id";
                        grid.Columns[18].FillWeight = 30;


                        grid.Columns[1].Visible = false;
                        grid.Columns[2].Visible = false;
                        grid.Columns[3].Visible = false;
                        grid.Columns[4].Visible = false;
                        grid.Columns[5].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[17].Visible = false;
                        grid.Columns[18].Visible = false;

                        for (int i = 0; i < 9; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                        for (int i = 13; i < 17; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }

                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                    break;
                case "noproc":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;

                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "№ изделия";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[1].HeaderText = "№ операции";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[2].HeaderText = "%ВГ 1 кв.";
                        grid.Columns[2].FillWeight = 30;
                        grid.Columns[3].HeaderText = "%ВГ 2 кв.";
                        grid.Columns[3].FillWeight = 30;
                        grid.Columns[4].HeaderText = "%ВГ 3 кв.";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "%ВГ 4 кв.";
                        grid.Columns[5].FillWeight = 30;
                
                        grid.Columns[6].HeaderText = "id";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[6].Visible = false;
                        grid.Columns[0].ReadOnly = true; grid.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
                        grid.Columns[1].ReadOnly = true; grid.Columns[1].DefaultCellStyle.BackColor = Color.LightGray;
                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                    break;
                case "noproc1":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;

                        grid.AutoGenerateColumns = true;
                       
                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[1].HeaderText = "%ВГ 1 кв.";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[2].HeaderText = "%ВГ 2 кв.";
                        grid.Columns[2].FillWeight = 30;
                        grid.Columns[3].HeaderText = "%ВГ 3 кв.";
                        grid.Columns[3].FillWeight = 30;
                        grid.Columns[4].HeaderText = "%ВГ 4 кв.";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "Коэфициент запуска1";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "Коэфициент запуска2";
                        grid.Columns[6].FillWeight = 35;
                        grid.Columns[7].HeaderText = "Коэфициент запуска3";
                        grid.Columns[7].FillWeight = 35;
                        grid.Columns[8].HeaderText = "Коэфициент запуска4";
                        grid.Columns[8].FillWeight = 35;
                        
                       
                       
                        grid.Columns[0].ReadOnly = true; grid.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
                        for (int i = 5; i < 9; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                    break;
                case "noproc2":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;

                        grid.AutoGenerateColumns = true;

                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[1].HeaderText = "Деталь";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[2].HeaderText = "Материал";
                        grid.Columns[2].FillWeight = 90;
                        grid.Columns[3].HeaderText = "Код материала";
                        grid.Columns[3].FillWeight = 30;
                        grid.Columns[4].HeaderText = "Коэфициент запуска1";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "Коэфициент запуска2";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "Коэфициент запуска3";
                        grid.Columns[6].FillWeight = 35;
                        grid.Columns[7].HeaderText = "Коэфициент запуска4";
                        grid.Columns[7].FillWeight = 35;
                        grid.Columns[8].HeaderText = "Норма";
                        grid.Columns[8].FillWeight = 35;
                        grid.Columns[8].DefaultCellStyle.Format = "N6";
                        grid.Columns[9].HeaderText = "Расчетная Норма";
                        grid.Columns[9].FillWeight = 35;
                        grid.Columns[9].DefaultCellStyle.Format = "N6";

                        for (int i = 0; i < 8; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                        grid.Columns[9].ReadOnly = true; grid.Columns[9].DefaultCellStyle.BackColor = Color.LightGray;
                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                        int kv = Formulation.kv(DateTime.Now);
                        if (kv == 1) { grid.Columns[5].Visible = false; grid.Columns[6].Visible = false; grid.Columns[7].Visible = false; }
                        if (kv == 2) { grid.Columns[4].Visible = false; grid.Columns[6].Visible = false; grid.Columns[7].Visible = false; }
                        if (kv == 3) { grid.Columns[5].Visible = false; grid.Columns[4].Visible = false; grid.Columns[7].Visible = false; }
                        if (kv == 4) { grid.Columns[5].Visible = false; grid.Columns[6].Visible = false; grid.Columns[4].Visible = false; }
                    }
                    break;
                default:
                    break;
            }
        }


        public static void GridSSJ(DataGridView grid, string s, string id, System.Data.DataTable dt)
        {
            ClassBD cbd = new ClassBD();
            switch (s)
            {
                case "rb":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;
                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[1].HeaderText = "Цех";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[2].HeaderText = "Наименование Технологической Операции";
                        grid.Columns[2].FillWeight = 100;
                        grid.Columns[3].HeaderText = "Наименование Материала";
                        grid.Columns[3].FillWeight = 150;
                        grid.Columns[4].HeaderText = "чертежный № (детали)";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "Код входящего компонента";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "Год";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[7].HeaderText = "№ позиции";
                        grid.Columns[7].FillWeight = 30;
                        grid.Columns[8].HeaderText = "Код единици измерения";
                        grid.Columns[8].FillWeight = 30;
                        grid.Columns[9].HeaderText = "% ВГ 1 квартал";
                        grid.Columns[9].FillWeight = 30;
                        grid.Columns[10].HeaderText = "% ВГ 2 квартал";
                        grid.Columns[10].FillWeight = 30;
                        grid.Columns[11].HeaderText = "% ВГ 3 квартал";
                        grid.Columns[11].FillWeight = 30;
                        grid.Columns[12].HeaderText = "% ВГ 4 квартал";
                        grid.Columns[12].FillWeight = 30;
                        grid.Columns[13].HeaderText = "Коэфициент запуска1";
                        grid.Columns[13].FillWeight = 30;
                        grid.Columns[14].HeaderText = "Коэфициент запуска2";
                        grid.Columns[14].FillWeight = 30;
                        grid.Columns[15].HeaderText = "Коэфициент запуска3";
                        grid.Columns[15].FillWeight = 30;
                        grid.Columns[16].HeaderText = "Коэфициент запуска4";
                        grid.Columns[16].FillWeight = 30;
                        grid.Columns[17].HeaderText = "Технологическая Норма";
                        grid.Columns[17].FillWeight = 30;
                        grid.Columns[17].DefaultCellStyle.Format = "N6";
                        grid.Columns[18].HeaderText = "id";
                        grid.Columns[18].FillWeight = 30;


                        grid.Columns[1].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[18].Visible = false;

                        //for (int i = 0; i < 9; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }
                        for (int i = 0; i < 18; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }

                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    }
                    break;
                case "sprtn":
                    {
                        //MessageBox.Show(id);
                        grid.DataSource = dt;
                        grid.AutoGenerateColumns = true;
                        grid.Columns[0].HeaderText = "№ операции";
                        grid.Columns[0].FillWeight = 30;
                        grid.Columns[1].HeaderText = "Цех";
                        grid.Columns[1].FillWeight = 30;
                        grid.Columns[2].HeaderText = "Наименование Технологической Операции";
                        grid.Columns[2].FillWeight = 100;
                        grid.Columns[3].HeaderText = "Наименование Материала";
                        grid.Columns[3].FillWeight = 150;
                        grid.Columns[4].HeaderText = "чертежный № (детали)";
                        grid.Columns[4].FillWeight = 30;
                        grid.Columns[5].HeaderText = "Код входящего компонента";
                        grid.Columns[5].FillWeight = 30;
                        grid.Columns[6].HeaderText = "№ позиции";
                        grid.Columns[6].FillWeight = 30;
                        grid.Columns[7].HeaderText = "Код единици измерения";
                        grid.Columns[7].FillWeight = 30;
                        
                        grid.Columns[8].HeaderText = "Технологическая Норма";
                        grid.Columns[8].FillWeight = 30;
                        grid.Columns[8].DefaultCellStyle.Format = "N6";
                        grid.Columns[9].HeaderText = "Цена";
                        grid.Columns[9].FillWeight = 30;
                        grid.Columns[9].DefaultCellStyle.Format = "N2";
                        grid.Columns[10].HeaderText = "id";
                        grid.Columns[10].FillWeight = 30;


                       // grid.Columns[1].Visible = false;
                       // grid.Columns[6].Visible = false;
                        grid.Columns[10].Visible = false;

                       
                        for (int i = 0; i < 8; i++) { grid.Columns[i].ReadOnly = true; grid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; }

                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    }
                    break;
                
                default:
                    break;
            }
        }

        public static void GridSS(DataGridView grid, string s, string id)
        {
            ClassBD cbd = new ClassBD();
            switch (s)
            {

                case "sprtn":
                    {
                        query = "select m.chn, m.no1, m.zex, m.naim, m.material, m.det, m.kwk2, m.npoz, m.kei, m.rgexp, m.b7, m.id from  SPR_TEX_NORM m order by m.no1";
                        //MessageBox.Show(query);
                        grid.DataSource = cbd.ConectBD3(1, query); 
                        grid.AutoGenerateColumns = true;

                        grid.Columns[0].HeaderText = "№ изделия";
                        grid.Columns[0].FillWeight = 30; grid.Columns[0].ReadOnly = true; grid.Columns[0].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[1].HeaderText = "№ операции";
                        grid.Columns[1].FillWeight = 30; grid.Columns[1].ReadOnly = true; grid.Columns[1].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[2].HeaderText = "Цех";
                        grid.Columns[2].FillWeight = 30; grid.Columns[2].ReadOnly = true; grid.Columns[2].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[3].HeaderText = "Наименование Технологической Операции";
                        grid.Columns[3].FillWeight = 100; grid.Columns[3].ReadOnly = true; grid.Columns[3].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[4].HeaderText = "Наименование Материала";
                        grid.Columns[4].FillWeight = 150; grid.Columns[4].ReadOnly = true; grid.Columns[4].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[5].HeaderText = "чертежный № (детали)";
                        grid.Columns[5].FillWeight = 30; grid.Columns[5].ReadOnly = true; grid.Columns[5].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[6].HeaderText = "Код входящего компонента";
                        grid.Columns[6].FillWeight = 30; grid.Columns[6].ReadOnly = true; grid.Columns[6].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[7].HeaderText = "№ позиции";
                        grid.Columns[7].FillWeight = 30; grid.Columns[7].ReadOnly = true; grid.Columns[7].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[8].HeaderText = "Код единици измерения";
                        grid.Columns[8].FillWeight = 30; grid.Columns[8].ReadOnly = true; grid.Columns[8].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[9].HeaderText = "Технологическая Норма";
                        grid.Columns[9].FillWeight = 30; grid.Columns[9].DefaultCellStyle.Format = "N6"; grid.Columns[9].ReadOnly = true; grid.Columns[9].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[10].HeaderText = "Цена";
                        grid.Columns[10].FillWeight = 30; grid.Columns[10].DefaultCellStyle.Format = "N2"; grid.Columns[10].ReadOnly = true; grid.Columns[10].DefaultCellStyle.BackColor = Color.LightGray; 

                        grid.Columns[11].HeaderText = "id"; grid.Columns[11].FillWeight = 30;

                        grid.Columns[11].Visible = false;

                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    }
                    break;

                default:
                    break;
            }
        }

        public static void factor_calculation(DataGridView grid, CheckedListBox clb)
        {
            double kof = 1;
            double c1 = 1;
            double cp1 = 1;
            double kp1 = 1;
            int k = grid.RowCount - 1;
            int i = grid.RowCount - 1;
            while (i > -1)
            {
                for (int col = 0; col < 4; col++)
                {
                    c1 = Convert.ToDouble(grid.Rows[i].Cells[col + 1].Value);
                    if (i != k) cp1 = Convert.ToDouble(grid.Rows[i + 1].Cells[col + 1].Value);
                    if (i != k) kp1 = Convert.ToDouble(grid.Rows[i + 1].Cells[col + 5].Value);

                    if (clb.GetItemChecked(col))
                    {
                        if (i != k) 
                        {
                            if (c1 != 100)
                            {
                                if (c1 != cp1)  { kof = kp1; }
                            }
                            else { kof = 1; }
                        }
                        else if (Convert.ToDouble(grid.Rows[k].Cells[col + 1].Value) != 100) { kof = Convert.ToDouble(grid.Rows[k].Cells[col + 5].Value); } else kof = 1;

                        grid.Rows[i].Cells[col + 5].Value = (kof * (100 / c1)).ToString();
                    }
                }
                i--;
            }

        }

        public static void group_DataGridView(DataGridView grid)
        {
            for (int j = 0; j < grid.ColumnCount; j++)
            {
                int i = grid.RowCount - 1;
                while (i > 0)
                {
                    if (grid.Rows[i].Cells[j].Value.ToString().Length > 1) 
                    { if (grid.Rows[i - 1].Cells[j].Value.ToString() == grid.Rows[i].Cells[j].Value.ToString()) grid.Rows[i].Cells[j].Value = ""; }
                    else grid.Rows[i].Cells[j].Value = "";
                    i--;
                }
            }
        }

        public static void group_DataGridView2(DataGridView grid)
        {
            //grid.ColumnCount = kol;
            for (int j = 0; j < 2; j++)
            {
                int k = 1;
                int jk = grid.RowCount - 1;
                while (jk > -1)
                {
                    if (j == 0)
                    {
                        if (grid.Rows[jk].Cells[j].Value.ToString().Length == 0) k++;
                        else
                        {
                            ((DataGridViewTextBoxCellEx)grid[j, jk]).RowSpan = k;
                            k = 1;
                        }
                    }
                    else
                    {
                        //проверяем предыдущую колонку
                    }
                    jk--;
                }
            }
        }
        public static void group_datatable(System.Data.DataTable dt)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                int i = dt.Rows.Count - 1;
                while (i > 0)
                {
                    if (dt.Rows[i][j].ToString().Length > 1)
                    { if (dt.Rows[i - 1][j].ToString() == dt.Rows[i][j].ToString()) dt.Rows[i][j] = ""; }
                    else dt.Rows[i][j] = "";
                    i--;
                }
            }
        }
        public static void group_color(DataGridView grid)
        {
            Color cl1 = Color.Aqua; Color cl2 = Color.Azure; Color cl3 = Color.Beige; Color cl4 = Color.Black; Color cl5 = Color.Brown;
        }

        public static T[,] Transpose<T>(T[,] matrix)
        {
            var transposeMatrix = new T[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposeMatrix[j, i] = matrix[i, j];
                }
            }
            return transposeMatrix;
        }

        public static System.Data.DataTable Transpose1(System.Data.DataTable dt, System.Data.DataTable dt1)
        {
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dt1.Rows[j][i] = dt.Rows[i][j];
                }
            }
             
            return dt1;
        }
        public static System.Data.DataTable Transpose2(System.Data.DataTable dt)
        {
            System.Data.DataTable newTable = new System.Data.DataTable();
            newTable.Columns.Add("Field Name");
            for (int i = 0; i < dt.Rows.Count; i++)
                newTable.Columns.Add();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                System.Data.DataRow newRow = newTable.NewRow();

                newRow[0] = dt.Columns[i].Caption;
                for (int j = 0; j < dt.Rows.Count; j++) newRow[j + 1] = dt.Rows[j][i];
                newTable.Rows.Add(newRow);
            }
            newTable.Columns.Remove("Field Name");

            return newTable;
        }
        public static void delete_empty_line(DataGridView grid) 
        {
            for (int i = grid.Rows.Count - 1; i > 0; --i)
            {
                DataGridViewRow row = grid.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value.ToString() == "" && row.Cells[1].Value.ToString() == ""
                     && row.Cells[2].Value.ToString() == "" && row.Cells[3].Value.ToString() == ""
                     && row.Cells[4].Value.ToString() == "" && row.Cells[5].Value.ToString() == ""
                     && row.Cells[6].Value.ToString() == "" && row.Cells[7].Value.ToString() == ""
                     && row.Cells[8].Value.ToString() == "" && row.Cells[9].Value.ToString() == "")
                {
                    grid.Rows.RemoveAt(i);
                }
            }
        }

        public static void delete_empty_line2(DataGridView grid)
        {
            for (int i = grid.Rows.Count - 1; i > 0; --i)
            {
                DataGridViewRow row = grid.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value.ToString() == "")
                {
                    grid.Rows.RemoveAt(i);
                }
            }
        }

        public static void delete_empty_line3(DataGridView grid)
        {
            for (int i = grid.Rows.Count - 1; i > 0; --i)
            {
                DataGridViewRow row = grid.Rows[i];
                if (row.Cells[0].Value.ToString() == "0")
                {
                    grid.Rows.RemoveAt(i);
                }
            }
        }

        public static void delete_empty_line4(DataGridView grid)
        {
            for (int i = grid.Rows.Count - 2; i > 0; --i)
            {
                DataGridViewRow row = grid.Rows[i];
                DataGridViewRow row1 = grid.Rows[i-1];
                if (row.Cells[0].Value.ToString() == row1.Cells[0].Value.ToString() && row.Cells[1].Value.ToString() == row1.Cells[1].Value.ToString()
                     && row.Cells[2].Value.ToString() == row1.Cells[2].Value.ToString() && row.Cells[3].Value.ToString() == row1.Cells[3].Value.ToString())
                {
                    grid.Rows.RemoveAt(i);
                }
            }
        }

        public static void loading_grid_list_data(List<SPR_MATERIAL> l, DataGridView grid)
        {
            grid.ColumnCount = 8;
            grid.RowCount = 0;// l.Count;
            int i = 0;
            foreach (var dl in l)
            {
                grid.Rows.Add(dl.chn, dl.NO1, dl.NPOZ, dl.MATERIAL, dl.KEI, dl.RGEXP, dl.b7, dl.kwk);
                i++;
            }
        }

        public static void loading_grid_list_data1(List<SPR_M> l, DataGridView grid)
        {
            grid.ColumnCount = 8;
            grid.RowCount = 0;
            foreach (var dl in l)
            {
                grid.Rows.Add(dl.chn, dl.NO1, dl.NPOZ, dl.MATERIAL, dl.KEI, dl.RGEXP, dl.b7, dl.kwk);
            }
        }
        public static void loading_grid_table_data(System.Data.DataTable dt, DataGridView grid)
        {
           // grid.ColumnCount = kol;
            grid.RowCount = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    grid[j, i].Value = dt.Rows[i][j];
                }
            }
            /*
            switch (kol)
            {
                case 0:
                    {
                        grid.Columns[0].Visible = false;
                        grid.Columns[1].Visible = false;
                        grid.Columns[2].Visible = false;
                        grid.Columns[3].Visible = false;
                        grid.Columns[4].Visible = false;
                        grid.Columns[5].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 1:
                    {
                        grid.Columns[1].Visible = false;
                        grid.Columns[2].Visible = false;
                        grid.Columns[3].Visible = false;
                        grid.Columns[4].Visible = false;
                        grid.Columns[5].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 2:
                    {
                        grid.Columns[2].Visible = false;
                        grid.Columns[3].Visible = false;
                        grid.Columns[4].Visible = false;
                        grid.Columns[5].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 3:
                    {
                        grid.Columns[3].Visible = false;
                        grid.Columns[4].Visible = false;
                        grid.Columns[5].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 4:
                    {
                        grid.Columns[4].Visible = false;
                        grid.Columns[5].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 5:
                    {
                        grid.Columns[5].Visible = false;
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 6:
                    {
                        grid.Columns[6].Visible = false;
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 7:
                    {
                        grid.Columns[7].Visible = false;
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 8:
                    {
                        grid.Columns[8].Visible = false;
                        grid.Columns[9].Visible = false;
                    }
                    break;
                case 9:
                    {
                        grid.Columns[9].Visible = false;
                    }
                    break;
                default:
                    break;
            }
             * */

        }
        public static void l_g_t_d(System.Data.DataTable dt, DataGridView grid, int count)
        {
            grid.RowCount = dt.Rows.Count + count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    grid[j + count, i].Value = dt.Rows[i][j];
                }
            }
        }

        public static void lgg1(DataGridView grid, DataGridView grid1)
        {
            int k = 0;
            int m = 0;

            for (int j = 0; j < grid.ColumnCount; j++) for (int i = 0; i < grid.RowCount; i++)if (grid[j, i].Value.ToString().Length > 1) if (i == 0) m++; else if (grid[j, i - 1].Value != grid[j, i].Value) m++;
     
              
            grid1.RowCount = m;
            
            for (int j = 0; j < grid.ColumnCount; j++)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    if (grid[j, i].Value.ToString().Length > 1)
                    {
                        if (i == 0)
                        {
                            grid1.Rows[k].Cells[0].Value = grid[j, i].Value;
                            k++;
                        }
                        else 
                        {
                            if (grid[j, i-1].Value != grid[j, i].Value)
                            {
                                grid1.Rows[k].Cells[0].Value = grid[j, i].Value;
                                k++;
                            }
                        }
                    }
                }
            }
        }

        

        public static void lgg3(DataGridView grid, DataGridView grid1, DataGridView grid2)
        {
            int k = 0; 
            int m = 0; int jm = 0;

            for (int j = 0; j < grid1.ColumnCount; j++)
            {
                for (int i = 0; i < grid1.RowCount; i++)
                {
                    if (grid1[j, i].Value.ToString().Length > 1)
                        if (i == 0)
                        { if (j == jm) m++; }
                        else
                            if (grid1[j, i - 1].Value != grid1[j, i].Value)
                            { if (j == jm) m++; }
                }
                if (j == jm) jm = j + 4;
            }

            grid2.ColumnCount = 4;
            grid2.Columns[0].HeaderText = "№ детали";
            grid2.Columns[0].FillWeight = 40; grid2.Columns[0].ReadOnly = true; grid2.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            grid2.Columns[1].HeaderText = "№ операции";
            grid2.Columns[1].FillWeight = 20; grid2.Columns[1].ReadOnly = true; grid2.Columns[1].DefaultCellStyle.BackColor = Color.LightGray;
            grid2.Columns[2].HeaderText = "№ позиции";
            grid2.Columns[2].FillWeight = 20; grid2.Columns[2].ReadOnly = true; grid2.Columns[2].DefaultCellStyle.BackColor = Color.LightGray;
            grid2.Columns[3].HeaderText = "Норма";
            grid2.Columns[3].FillWeight = 25; grid2.Columns[3].ReadOnly = true; grid2.Columns[3].DefaultCellStyle.BackColor = Color.LightGray;
            grid2.Columns[3].DefaultCellStyle.Format = "N6";

            grid2.RowCount = m*3;
            for (int i = 0; i < grid2.RowCount; i++){ grid2.Rows[i].Cells[0].Value = "0"; }
          

            jm = 0;
            for (int j = 0; j < grid.ColumnCount; j++)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    //if (k == m) { delete_empty_line4(grid2); k = grid2.RowCount-1; }
                    if (grid[j, i].Value.ToString().Length > 1)
                    {
                        string z = grid[j, i].Value.ToString();
                        if (i == 0)
                        {
                            for (int i1 = 0; i1 < grid1.RowCount; i1++)
                            {
                                if (grid1[jm, i1].Value.ToString() == z)
                                {
                                      grid2.Rows[k].Cells[0].Value = grid1[jm, i1].Value;
                                      grid2.Rows[k].Cells[1].Value = grid1[jm + 1, i1].Value;
                                      grid2.Rows[k].Cells[2].Value = grid1[jm + 2, i1].Value;
                                      grid2.Rows[k].Cells[3].Value = grid1[jm + 3, i1].Value;
                                      k++;
                                }
                            }
                        }
                        else if (grid[j, i - 1].Value != grid[j, i].Value)
                        {
                            for (int i1 = 0; i1 < grid1.RowCount; i1++)
                            {
                                if (grid1[jm, i1].Value.ToString() == z)
                                {
                                      grid2.Rows[k].Cells[0].Value = grid1[jm, i1].Value;
                                      grid2.Rows[k].Cells[1].Value = grid1[jm + 1, i1].Value;
                                      grid2.Rows[k].Cells[2].Value = grid1[jm + 2, i1].Value;
                                      grid2.Rows[k].Cells[3].Value = grid1[jm + 3, i1].Value;
                                      k++;
                                }
                            }
                        }
                    }
                }
                jm = jm + 4;
            }
        }

        public static void Clear1(DataGridView gd)
        {
            ArrayList al = new ArrayList();
            gd.DataSource = al;
        }
        public static void Clear(DataGridView gd)
        {
            gd.Rows.Clear();  // удаление всех строк 
            int count = gd.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов 
            { gd.Columns.RemoveAt(0); }
        }

        public static void Clear2(DataGridView gd)
        {
            int r= gd.Rows.Count;  // удаление всех строк 
            //int count = gd.Columns.Count;
            for (int i = 0; i < r-1; i++)     // цикл удаления всех столбцов 
            { gd.Rows.RemoveAt(i); }
        }
    }
}
