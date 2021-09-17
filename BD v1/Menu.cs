using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BD_v1
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu(int _role)
        {
            InitializeComponent();
            role = _role;
            switch(role)
            {
                case (1):
                    администрированиеToolStripMenuItem.Visible = true;
                    break;
                case (2):
                    администрированиеToolStripMenuItem.Visible = true;
                    break;
            }
        }
        int role;
        string Table;
        string SQLCode;
        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=University_information_system;Uid=root;Pwd=;charset=utf8");
            con.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(SQLCode, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.Columns[0].Visible = false;
           
        }
            private void СтудентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Student.ID_student,Sex.Sex,Student.FIO,Student.Phone,Student.Address,Presence_of_children.Name,Student.DateB FROM Student, Presence_of_children, Sex WHERE Sex.ID_sex = Student.ID_sex AND Presence_of_children.ID_Presence_of_children = Student.ID_presence";
            Table = "Студенты";
            refresh();
        }

        private void ПолToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT ID_sex,Sex as 'Пол' FROM Sex";
            Table = "Пол";
            refresh();
        }

        private void ПреподователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Teacher.ID_teacher,Teacher.DateB as 'Дата рождения',Teacher.FIO as 'ФИО',Presence_of_children_and_their_number.Numder_of_children as 'Количество детей',Sex.Sex as 'Пол',Category.Name as 'Должность',Teacher.topic_of_candidanscai as 'Кандидатская работа',Teacher.topic_of_doctorial_dissertation as 'Докторская работа',Department.Name as 'Кафедра' FROM Teacher, Presence_of_children_and_their_number,Sex,Category,Department WHERE Teacher.ID_presence_and_number=Presence_of_children_and_their_number.ID_presence_of_children_and_their_number AND Teacher.ID_sex=Sex.ID_sex AND Teacher.ID_category=Category.ID_category AND Teacher.ID_department=Department.ID_department";
            Table = "Преподователи";
            refresh();
        }

        private void СтипендияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Summa_stipendii.ID_summa_stipendii,Summa_stipendii.Summa_stipendii as 'Размер стипендии',Sing_receeived.Name as 'Прицина выдачи стипендии',Student.FIO as 'ФИО', Summa_stipendii.dateTime as 'Дата и время' FROM Summa_stipendii, Sing_receeived, Student WHERE Summa_stipendii.ID_sign_received=Sing_receeived.ID_sing_receeived AND Summa_stipendii.ID_student=Student.ID_student";
            Table = "Стипендия";
            refresh();
        }

        private void ПредметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT ID_subject,Name as 'Предмет' FROM Subject";
            Table = "Предмет";
            refresh();
        }

        private void РасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Raspisanie.ID_raspisanie,Raspisanie.DateTime as 'Дата и время',Groupa.Name as 'Группа',Class_type.Name as 'Тип занятия',Subject.Name as 'Предмет',Teacher.FIO as 'Преподователь' FROM Raspisanie,Groupa,Class_type,Subject,Teacher WHERE Raspisanie.ID_group=Groupa.ID_group AND Raspisanie.ID_class_type=Class_type.ID_class_type AND Raspisanie.ID_subject=Subject.ID_subject AND Raspisanie.ID_teacher=Teacher.ID_teacher";
            Table = "Расписание";
            refresh();
        }

        private void КонтрольЗнанийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Prisvaivanie_kontrol.ID_prisvaivanie, Form_of_control.Name as 'Форма контроля',Groupa.Name as 'Группа' FROM Prisvaivanie_kontrol,Form_of_control,Groupa WHERE Prisvaivanie_kontrol.ID_form_of_control=Form_of_control.ID_form_of_control AND Groupa.ID_group=Prisvaivanie_kontrol.ID_group";
            Table = "Контроль знаний";
            refresh();
        }

        private void ГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Groupa.ID_group,Couse.Name as 'Курс', Groupa.Name FROM Groupa,Couse WHERE Couse.ID_course=Groupa.ID_course";
            Table = "Группа";
            refresh();
        }

        private void ФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Faculty.ID_faculty,Department.Name as 'Кафедра', Faculty.Name AS 'Факультет' FROM Faculty,Department WHERE Faculty.ID_department=Department.ID_department";
            Table = "Факультет";
            refresh();
        }

        private void ОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Evaluation.ID_evaluation,Evaluation.Evaluation as 'Оценка',Subject.Name as 'Предмет',Student.FIO as 'ФИО', Evaluation.DateTime as 'Дата и время' FROM Subject,Student,Evaluation WHERE Evaluation.ID_subject=Subject.ID_subject AND Evaluation.ID_student=Student.ID_student";
            Table = "Оценки";
            refresh();
        }

        private void ДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Employment.ID_employment,Teacher.FIO as 'ФИО',Pos.Name as 'Должность',Employment.Date as 'Дата' FROM Employment,Teacher,Pos WHERE Employment.ID_teacher=Teacher.ID_teacher AND Employment.ID_position=Pos.ID_position";
            Table = "Должности";
            refresh();
        }

        private void КафедраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT ID_department,Name as 'Кафедра' FROM Department";
            Table = "Кафедра";
            refresh();
        }

        private void КурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT Couse.ID_course, Faculty.Name as 'Факультет', Couse.Name as 'Курс' FROM Couse,Faculty WHERE Couse.ID_faculty=Faculty.ID_faculty";
            Table = "Курс";
            refresh();
        }

        private void ЗаписьВГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLCode = "SELECT admission_to_the_group.iD_admission_to_the_group,admission_to_the_group.Date as 'Дата',Student.FIO as 'ФИО',Groupa.Name as 'Группа' FROM admission_to_the_group,Student,Groupa WHERE admission_to_the_group.ID_student=Student.ID_student AND admission_to_the_group.ID_group=Groupa.ID_group";
            Table = "Запись в группу";
            refresh();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void УправлениеУчетнымиЗаписямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regis REG = new Regis(role);
            REG.Show();
        }
        
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            switch (Table)
            {
                case "Студенты":
                    InsertStudent iS = new InsertStudent(-1);
                    iS.ShowDialog();
                    refresh();
                    break;
                case ("Преподователи"):
                    InsertTeacher iT = new InsertTeacher(-1);
                    iT.ShowDialog();
                    refresh();
                    break;
                case ("Стипендия"):
                    InsertSumma_stipendii iSs = new InsertSumma_stipendii(-1);
                    iSs.ShowDialog();
                    refresh();
                    break;
                case ("Предмет"):
                    InsertSubject iSub = new InsertSubject(-1);
                    iSub.ShowDialog();
                    refresh();
                    break;
                case ("Расписание"):
                    InsertRaspisanie Ras = new InsertRaspisanie(-1);
                    Ras.ShowDialog();
                    refresh();
                    break;
                case ("Контроль знаний"):
                    InsertPrisvaivanie_kontrol For = new InsertPrisvaivanie_kontrol(-1);
                    For.ShowDialog();
                    refresh();
                    break;
                case ("Группа"):
                    InsertGroup ig = new InsertGroup(-1);
                    ig.ShowDialog();
                    refresh();
                    break;
                case ("Факультет"):
                    InsertFaculty Fac = new InsertFaculty(-1);
                    Fac.ShowDialog();
                    refresh();
                    break;
                case ("Оценки"):
                    InsertEvaluation Eva = new InsertEvaluation(-1);
                    Eva.ShowDialog();
                    refresh();
                    break;
                case ("Должности"):
                    InsertEmployment Emp = new InsertEmployment(-1);
                    Emp.ShowDialog();
                    refresh();
                    break;
                case ("Кафедра"):
                    InsertDepartament Dep = new InsertDepartament(-1);
                    Dep.ShowDialog();
                    refresh();
                    break;
                case ("Курс"):
                    InsertCouse Cou = new InsertCouse(-1);
                    Cou.ShowDialog();
                    refresh();
                    break;
                case ("Запись в группу"):
                    InsertAdmission_to_the_group Adm = new InsertAdmission_to_the_group(-1);
                    Adm.ShowDialog();
                    refresh();
                    break;
                case ("Пол"):
                    Insert insert = new Insert(-1);
                    insert.ShowDialog();
                    refresh();
                    break;
            }
        }


        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex !=-1)
            try
            { 
                int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                switch (Table)
                {
                    case "Студенты":
                        InsertStudent iS = new InsertStudent(id);
                        iS.ShowDialog();
                        refresh();
                        break;
                    case ("Преподователи"):
                        InsertTeacher iT = new InsertTeacher(id);
                        iT.ShowDialog();
                        refresh();
                        break;
                    case ("Стипендия"):
                        InsertSumma_stipendii iSs = new InsertSumma_stipendii(id);
                        iSs.ShowDialog();
                        refresh();
                        break;
                    case ("Предмет"):
                        InsertSubject iSub = new InsertSubject(id);
                        iSub.ShowDialog();
                        refresh();
                        break;
                    case ("Расписание"):
                        InsertRaspisanie Ras = new InsertRaspisanie(id);
                        Ras.ShowDialog();
                        refresh();
                        break;
                    case ("Контроль знаний"):
                        InsertPrisvaivanie_kontrol For = new InsertPrisvaivanie_kontrol(id);
                        For.ShowDialog();
                        refresh();
                        break;
                    case ("Группа"):
                        InsertGroup ig = new InsertGroup(id);
                        ig.ShowDialog();
                        refresh();
                        break;
                    case ("Факультет"):
                        InsertFaculty Fac = new InsertFaculty(id);
                        Fac.ShowDialog();
                        refresh();
                        break;
                    case ("Оценки"):
                        InsertEvaluation Eva = new InsertEvaluation(id);
                        Eva.ShowDialog();
                        refresh();
                        break;
                    case ("Должности"):
                        InsertEmployment Emp = new InsertEmployment(id);
                        Emp.ShowDialog();
                        refresh();
                        break;
                    case ("Кафедра"):
                        InsertDepartament Dep = new InsertDepartament(id);
                        Dep.ShowDialog();
                        refresh();
                        break;
                    case ("Курс"):
                        InsertCouse Cou = new InsertCouse(id);
                        Cou.ShowDialog();
                        refresh();
                        break;
                    case ("Запись в группу"):
                        InsertAdmission_to_the_group Adm = new InsertAdmission_to_the_group(id);
                        Adm.ShowDialog();
                        refresh();
                        break;
                    case ("Пол"):
                        Insert insert = new Insert(id);
                        insert.ShowDialog();
                        refresh();
                        break;
                }
            }
            catch
            { }
        }

        private void StudentFIOTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Student.ID_student,Sex.Sex,Student.FIO,Student.Phone,Student.Address,Presence_of_children.Name,Student.DateB FROM Student, Presence_of_children, Sex WHERE Sex.ID_sex = Student.ID_sex AND Presence_of_children.ID_Presence_of_children = Student.ID_presence AND Student.FIO like '%{StudentFIOTextBox.Text}%'";
            Table = "Студенты";
            refresh();
        }

        private void StudentTelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Student.ID_student,Sex.Sex,Student.FIO,Student.Phone,Student.Address,Presence_of_children.Name,Student.DateB FROM Student, Presence_of_children, Sex WHERE Sex.ID_sex = Student.ID_sex AND Presence_of_children.ID_Presence_of_children = Student.ID_presence AND Student.Phone like '%{StudentTelTextBox.Text}%'";
            Table = "Студенты";
            refresh();
        }

        private void StudentAdressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Student.ID_student,Sex.Sex,Student.FIO,Student.Phone,Student.Address,Presence_of_children.Name,Student.DateB FROM Student, Presence_of_children, Sex WHERE Sex.ID_sex = Student.ID_sex AND Presence_of_children.ID_Presence_of_children = Student.ID_presence AND Student.Address like '%{StudentAdressTextBox.Text}%'";
            Table = "Студенты";
            refresh();
        }

        private void TeacherFIOTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Teacher.ID_teacher,Teacher.DateB as 'Дата рождения',Teacher.FIO as 'ФИО',Presence_of_children_and_their_number.Numder_of_children as 'Количество детей',Sex.Sex as 'Пол',Category.Name as 'Должность',Teacher.topic_of_candidanscai as 'Кандидатская работа',Teacher.topic_of_doctorial_dissertation as 'Докторская работа',Department.Name as 'Кафедра' FROM Teacher, Presence_of_children_and_their_number,Sex,Category,Department WHERE Teacher.ID_presence_and_number=Presence_of_children_and_their_number.ID_presence_of_children_and_their_number AND Teacher.ID_sex=Sex.ID_sex AND Teacher.ID_category=Category.ID_category AND Teacher.ID_department=Department.ID_department AND Teacher.FIO like '%{TeacherFIOTextBox.Text}%'";
            Table = "Преподователи";
            refresh();
        }

        private void TeacherCanditTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Teacher.ID_teacher,Teacher.DateB as 'Дата рождения',Teacher.FIO as 'ФИО',Presence_of_children_and_their_number.Numder_of_children as 'Количество детей',Sex.Sex as 'Пол',Category.Name as 'Должность',Teacher.topic_of_candidanscai as 'Кандидатская работа',Teacher.topic_of_doctorial_dissertation as 'Докторская работа',Department.Name as 'Кафедра' FROM Teacher, Presence_of_children_and_their_number,Sex,Category,Department WHERE Teacher.ID_presence_and_number=Presence_of_children_and_their_number.ID_presence_of_children_and_their_number AND Teacher.ID_sex=Sex.ID_sex AND Teacher.ID_category=Category.ID_category AND Teacher.ID_department=Department.ID_department AND Teacher.topic_of_candidanscai like '%{TeacherCanditTextBox.Text}%'";
            Table = "Преподователи";
            refresh();
        }

        private void TeacherDoctorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Teacher.ID_teacher,Teacher.DateB as 'Дата рождения',Teacher.FIO as 'ФИО',Presence_of_children_and_their_number.Numder_of_children as 'Количество детей',Sex.Sex as 'Пол',Category.Name as 'Должность',Teacher.topic_of_candidanscai as 'Кандидатская работа',Teacher.topic_of_doctorial_dissertation as 'Докторская работа',Department.Name as 'Кафедра' FROM Teacher, Presence_of_children_and_their_number,Sex,Category,Department WHERE Teacher.ID_presence_and_number=Presence_of_children_and_their_number.ID_presence_of_children_and_their_number AND Teacher.ID_sex=Sex.ID_sex AND Teacher.ID_category=Category.ID_category AND Teacher.ID_department=Department.ID_department AND Teacher.topic_of_doctorial_dissertation like '%{TeacherDoctorTextBox.Text}%'";
            Table = "Преподователи";
            refresh();
        }
        

        private void SummstipFIOTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Summa_stipendii.ID_summa_stipendii,Summa_stipendii.Summa_stipendii as 'Размер стипендии',Sing_receeived.Name as 'Прицина выдачи стипендии',Student.FIO as 'ФИО', Summa_stipendii.dateTime as 'Дата и время' FROM Summa_stipendii, Sing_receeived, Student WHERE Summa_stipendii.ID_sign_received=Sing_receeived.ID_sing_receeived AND Summa_stipendii.ID_student=Student.ID_student AND Student.FIO LIKE '%{SummstipPrichinTextBox.Text}%'";
            Table = "Стипендия";
            refresh();
        }

        private void SummstipStipenTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Summa_stipendii.ID_summa_stipendii,Summa_stipendii.Summa_stipendii as 'Размер стипендии',Sing_receeived.Name as 'Прицина выдачи стипендии',Student.FIO as 'ФИО', Summa_stipendii.dateTime as 'Дата и время' FROM Summa_stipendii, Sing_receeived, Student WHERE Summa_stipendii.ID_sign_received=Sing_receeived.ID_sing_receeived AND Summa_stipendii.ID_student=Student.ID_student AND Summa_stipendii.Summa_stipendii LIKE '%{SummstipStipenTextBox.Text}%'";
            Table = "Стипендия";
            refresh();
        }

        private void SummstipPrichinTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Summa_stipendii.ID_summa_stipendii,Summa_stipendii.Summa_stipendii as 'Размер стипендии',Sing_receeived.Name as 'Прицина выдачи стипендии',Student.FIO as 'ФИО', Summa_stipendii.dateTime as 'Дата и время' FROM Summa_stipendii, Sing_receeived, Student WHERE Summa_stipendii.ID_sign_received=Sing_receeived.ID_sing_receeived AND Summa_stipendii.ID_student=Student.ID_student AND Sing_receeived.Name LIKE '%{SummstipPrichinTextBox.Text}%'";
            Table = "Стипендия";
            refresh();
        }

        private void SubjectTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT ID_subject,Name as 'Предмет' FROM Subject WHERE Name LIKE '%{SubjectTextBox.Text}%'";
            Table = "Предмет";
            refresh();
        }

        private void FormconGrupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Raspisanie.ID_raspisanie,Raspisanie.DateTime as 'Дата и время',Groupa.Name as 'Группа',Class_type.Name as 'Тип занятия',Subject.Name as 'Предмет',Teacher.FIO as 'Преподователь' FROM Raspisanie,Groupa,Class_type,Subject,Teacher WHERE Raspisanie.ID_group=Groupa.ID_group AND Raspisanie.ID_class_type=Class_type.ID_class_type AND Raspisanie.ID_subject=Subject.ID_subject AND Raspisanie.ID_teacher=Teacher.ID_teacher AND Groupa.Name LIKE '%{RaspisanieGrupTextBox.Text}%'";
            Table = "Расписание";
            refresh();
        }

        private void ToolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Raspisanie.ID_raspisanie,Raspisanie.DateTime as 'Дата и время',Groupa.Name as 'Группа',Class_type.Name as 'Тип занятия',Subject.Name as 'Предмет',Teacher.FIO as 'Преподователь' FROM Raspisanie,Groupa,Class_type,Subject,Teacher WHERE Raspisanie.ID_group=Groupa.ID_group AND Raspisanie.ID_class_type=Class_type.ID_class_type AND Raspisanie.ID_subject=Subject.ID_subject AND Raspisanie.ID_teacher=Teacher.ID_teacher AND Subject.Name LIKE '%{RaspisanieSubjectTextBox.Text}%'";
            Table = "Расписание";
            refresh();
        }

        private void FormconClassTypeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Raspisanie.ID_raspisanie,Raspisanie.DateTime as 'Дата и время',Groupa.Name as 'Группа',Class_type.Name as 'Тип занятия',Subject.Name as 'Предмет',Teacher.FIO as 'Преподователь' FROM Raspisanie,Groupa,Class_type,Subject,Teacher WHERE Raspisanie.ID_group=Groupa.ID_group AND Raspisanie.ID_class_type=Class_type.ID_class_type AND Raspisanie.ID_subject=Subject.ID_subject AND Raspisanie.ID_teacher=Teacher.ID_teacher AND Class_type.Name LIKE '%{RaspisanieClassTypeTextBox.Text}%'";
            Table = "Расписание";
            refresh();
        }

        private void FormconTeacherTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Raspisanie.ID_raspisanie,Raspisanie.DateTime as 'Дата и время',Groupa.Name as 'Группа',Class_type.Name as 'Тип занятия',Subject.Name as 'Предмет',Teacher.FIO as 'Преподователь' FROM Raspisanie,Groupa,Class_type,Subject,Teacher WHERE Raspisanie.ID_group=Groupa.ID_group AND Raspisanie.ID_class_type=Class_type.ID_class_type AND Raspisanie.ID_subject=Subject.ID_subject AND Raspisanie.ID_teacher=Teacher.ID_teacher AND Teacher.FIO LIKE '%{RaspisanieTeacherTextBox.Text}%'";
            Table = "Расписание";
            refresh();
        }

        private void PrisvaivanieFormconTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Prisvaivanie_kontrol.ID_prisvaivanie, Form_of_control.Name as 'Форма контроля',Groupa.Name as 'Группа' FROM Prisvaivanie_kontrol,Form_of_control,Groupa WHERE Prisvaivanie_kontrol.ID_form_of_control=Form_of_control.ID_form_of_control AND Groupa.ID_group=Prisvaivanie_kontrol.ID_group AND Form_of_control.Name LIKE '%{PrisvaivanieFormconTextBox.Text}%'";
            Table = "Контроль знаний";
            refresh();
        }

        private void PrisvaivanieGrupaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Prisvaivanie_kontrol.ID_prisvaivanie, Form_of_control.Name as 'Форма контроля',Groupa.Name as 'Группа' FROM Prisvaivanie_kontrol,Form_of_control,Groupa WHERE Prisvaivanie_kontrol.ID_form_of_control=Form_of_control.ID_form_of_control AND Groupa.ID_group=Prisvaivanie_kontrol.ID_group AND Groupa.Name LIKE '%{PrisvaivanieGrupaTextBox.Text}%'";
            Table = "Контроль знаний";
            refresh();
        }

        private void GrupaCourseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Groupa.ID_group,Couse.Name as 'Курс', Groupa.Name FROM Groupa,Couse WHERE Couse.ID_course=Groupa.ID_course AND Couse.Name LIKE '%{GrupaCourseTextBox.Text}%'";
            Table = "Группа";
            refresh();
        }

        private void GrupaGrupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Groupa.ID_group,Couse.Name as 'Курс', Groupa.Name FROM Groupa,Couse WHERE Couse.ID_course=Groupa.ID_course AND Groupa.Name LIKE '%{GrupaGrupTextBox.Text}%'";
            Table = "Группа";
            refresh();
        }

        private void FacultyDeptTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Faculty.ID_faculty,Department.Name as 'Кафедра', Faculty.Name AS 'Факультет' FROM Faculty,Department WHERE Faculty.ID_department=Department.ID_department AND Department.Name LIKE '%{FacultyDeptTextBox.Text}%'";
            Table = "Факультет";
            refresh();
        }

        private void FacultyFaculTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Faculty.ID_faculty,Department.Name as 'Кафедра', Faculty.Name AS 'Факультет' FROM Faculty,Department WHERE Faculty.ID_department=Department.ID_department AND Faculty.Name LIKE '%{FacultyFaculTextBox.Text}%'";
            Table = "Факультет";
            refresh();
        }

        private void EvaluStudentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Evaluation.ID_evaluation,Evaluation.Evaluation as 'Оценка',Subject.Name as 'Предмет',Student.FIO as 'ФИО', Evaluation.DateTime as 'Дата и время' FROM Subject,Student,Evaluation WHERE Evaluation.ID_subject=Subject.ID_subject AND Evaluation.ID_student=Student.ID_student AND Student.FIO LIKE '%{EvaluStudentTextBox.Text}%'";
            Table = "Оценки";
            refresh();
        }

        private void EvaluSubjectTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Evaluation.ID_evaluation,Evaluation.Evaluation as 'Оценка',Subject.Name as 'Предмет',Student.FIO as 'ФИО', Evaluation.DateTime as 'Дата и время' FROM Subject,Student,Evaluation WHERE Evaluation.ID_subject=Subject.ID_subject AND Evaluation.ID_student=Student.ID_student AND Subject.Name LIKE '%{SubjectTextBox.Text}%'";
            Table = "Оценки";
            refresh();
        }

        private void EmploymentPositionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Employment.ID_employment,Teacher.FIO as 'ФИО',Pos.Name as 'Должность',Employment.Date as 'Дата' FROM Employment,Teacher,Pos WHERE Employment.ID_teacher=Teacher.ID_teacher AND Employment.ID_position=Pos.ID_position AND Pos.Name LIKE '%{EmploymentPositionTextBox.Text}%'";
            Table = "Должности";
            refresh();
        }

        private void EmploymentTeacherTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Employment.ID_employment,Teacher.FIO as 'ФИО',Pos.Name as 'Должность',Employment.Date as 'Дата' FROM Employment,Teacher,Pos WHERE Employment.ID_teacher=Teacher.ID_teacher AND Employment.ID_position=Pos.ID_position AND Teacher.FIO LIKE '%{EmploymentTeacherTextBox.Text}%'";
            Table = "Должности";
            refresh();
        }

        private void DepartmentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT ID_department,Name as 'Кафедра' FROM Department WHERE Department.Name LIKE '%{DepartmentTextBox.Text}%'";
            Table = "Кафедра";
            refresh();
        }

        private void CourseCourseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Couse.ID_course, Faculty.Name as 'Факультет', Couse.Name as 'Курс' FROM Couse,Faculty WHERE Couse.ID_faculty=Faculty.ID_faculty AND Couse.Name LIKE '%{CourseCourseTextBox.Text}%'";
            Table = "Курс";
            refresh();
        }

        private void CourseFacultuTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT Couse.ID_course, Faculty.Name as 'Факультет', Couse.Name as 'Курс' FROM Couse,Faculty WHERE Couse.ID_faculty=Faculty.ID_faculty AND Faculty.Name LIKE '%{CourseFacultuTextBox.Text}%'";
            Table = "Курс";
            refresh();
        }

        private void AdmisionGroupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT admission_to_the_group.iD_admission_to_the_group,admission_to_the_group.Date as 'Дата',Student.FIO as 'ФИО',Groupa.Name as 'Группа' FROM admission_to_the_group,Student,Groupa WHERE admission_to_the_group.ID_student=Student.ID_student AND admission_to_the_group.ID_group=Groupa.ID_group AND Groupa.Name LIKE '%{AdmisionGroupTextBox.Text}%'";
            Table = "Запись в группу";
            refresh();
        }

        private void AdmisionStudentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SQLCode = $"SELECT admission_to_the_group.iD_admission_to_the_group,admission_to_the_group.Date as 'Дата',Student.FIO as 'ФИО',Groupa.Name as 'Группа' FROM admission_to_the_group,Student,Groupa WHERE admission_to_the_group.ID_student=Student.ID_student AND admission_to_the_group.ID_group=Groupa.ID_group AND Student.FIO LIKE '%{AdmisionStudentTextBox.Text}%'";
            Table = "Запись в группу";
            refresh();
        }

        private void PolzivatilRefresh_Click(object sender, EventArgs e)
        {
            Auth a = new Auth();
            a.Show();
            Hide();
        }
    }
}
