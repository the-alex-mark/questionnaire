using Designer.Properties;
using Designer.Data;
using Questionnaire.Controls;
using Questionnaire.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgLib;

namespace Designer
{
    public partial class FormDesigner : Form
    {
        #region Import

        [System.Runtime.InteropServices.DllImport("USER32", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private extern static Boolean PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [System.Runtime.InteropServices.DllImport("USER32", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private extern static Boolean ReleaseCapture();

        #endregion

        #region Shadow

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message e)
        {
            switch (e.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;

                //case 70:
                //    Rectangle WorkingArea = SystemInformation.WorkingArea;
                //    Rectangle Rectangle = (Rectangle)System.Runtime.InteropServices.Marshal.PtrToStructure((IntPtr)((long)(IntPtr.Size * 2) + e.LParam.ToInt64()), typeof(Rectangle));
                //    if (Rectangle.X <= WorkingArea.Left + 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2, WorkingArea.Left);
                //    if (Rectangle.X + Rectangle.Width >= WorkingArea.Width - 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2, WorkingArea.Right - Rectangle.Width);
                //    if (Rectangle.Y <= WorkingArea.Top + 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2 + 4, WorkingArea.Top);
                //    if (Rectangle.Y + Rectangle.Height >= WorkingArea.Height - 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2 + 4, WorkingArea.Bottom - Rectangle.Height);
                //    break;

                default: break;
            }
            base.WndProc(ref e);
        }


        #endregion

        public FormDesigner()
        {
            InitializeComponent();

            // Установка максимального размера завёртывания формы
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Растяжение формы
            MouseMove += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    if (_mouseEventArgs.X >= Width - 4 && _mouseEventArgs.Y >= Height - 4) { Cursor = Cursors.SizeNWSE; }
                    else if (_mouseEventArgs.X >= Width - 4 && _mouseEventArgs.Y > 25) { Cursor = Cursors.SizeWE; }
                    else if (_mouseEventArgs.Y >= Height - 4) { Cursor = Cursors.SizeNS; }
                    else { Cursor = Cursors.Default; }
                }
            };
            MouseDown += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    uint Param = 0;

                    if (Cursor == Cursors.Default) { Param = 0; }
                    else
                    if (Cursor == Cursors.SizeNWSE) { Param = 0xF008; }
                    else
                    if (Cursor == Cursors.SizeWE) { Param = 0xF002; }
                    else
                    if (Cursor == Cursors.SizeNS) { Param = 0xF006; }

                    ReleaseCapture();
                    PostMessage(Handle, 0x0112, Param, 0);
                }
            };

            // Оформление MainMenu
            MainMenu.Renderer = new MenuRenderer();
            MainMenu.MouseDown += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                ReleaseCapture();
                PostMessage(Handle, 0x0112, 0xF012, 0);
            };
            MainMenu.Items["mmMinimum"].Click += delegate (Object _object, EventArgs _eventArgs)
            {
                WindowState = FormWindowState.Minimized;
            };
            MainMenu.Items["mmMaximum"].Click += delegate (Object _object, EventArgs _eventArgs)
            {
                WindowState = (WindowState == FormWindowState.Maximized)
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };
            MainMenu.Items["mmClose"].Click += delegate (Object _object, EventArgs _eventArgs)
            {
                Close();
            };

            // Оформление ListBox
            OnStyleListBox(listQuestions);
        }

        #region Global Variables

        private Survey _survey = new Survey();
        private String _file = "";

        //private Boolean _created = false;
        private Boolean _rewrite = false;
        private Int32 _currentIndex = -1, _previousIndex = -1;

        #endregion

        #region Methods

        /// <summary>
        /// Обновляет отображение вопроса
        /// </summary>
        /// <param name="Question"></param>
        private void Update(Question Question)
        {
            Clear();
            tQuestion.Text = Question.Name;

            if (Question.Image != null)
            {
                pImage.Image = Question.Image;
                _survey.Questions[listQuestions.SelectedIndex].Image = Question.Image;

                pImage.Visible = true;
                pictureBox1.Visible = true;
            }
            else
            {
                pImage.Visible = false;
                pictureBox1.Visible = false;
            }

            Int32 Y = -80;
            for (int i = 1; i <= ((Question.Type == "Свободный ответ") ? 1 : Question.Answers.Count); i++)
            {
                ViewAnswer viewAnswer = new ViewAnswer
                {
                    Text = Question.Answers[i - 1],
                    Size = new Size(panel2.Width, 69),
                    Location = new Point(0, Y += 80),
                    Margin = new Padding(0, 0, 0, 0),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    TabIndex = i + 2,

                    Name = "pAnswer" + i.ToString(),
                    Parent = listAnswers,
                };
            }

            switch (Question.Type)
            {
                case "Выбор одного правильного ответа":
                    foreach (Control Control in listAnswers.Controls)
                    {
                        if (Control is ViewAnswer)
                        {
                            (Control as ViewAnswer).TrueChanged += delegate (Object _object, EventArgs _eventArgs)
                            {
                                foreach (ViewAnswer Answer in listAnswers.Controls)
                                {
                                    if (Answer.Name != Control.Name)
                                        Answer.True = (Control as ViewAnswer).True ? false : true;
                                }
                            };

                            (Control as ViewAnswer).True = false;
                        }
                    }

                    True(Question);

                    addAnswer.Visible = true;
                    addImage.Visible = true;

                    mSingleAnswerSelection.Checked = true;
                    mFreeAnswer.Checked = false;
                    break;

                case "Свободный ответ":
                    foreach (ViewAnswer Answer in listAnswers.Controls)
                        Answer.VisibleTrue = Answer.VisibleDelete = false;

                    addAnswer.Visible = false;
                    addImage.Visible = false;

                    mSingleAnswerSelection.Checked = false;
                    mFreeAnswer.Checked = true;
                    break;

                default: break;
            }
        }

        /// <summary>
        /// Очищает список отображённых ответов  
        /// </summary>
        private void Clear()
        {
            listAnswers.Controls.Clear();
        }

        /// <summary>
        /// Обновляет значение правильного ответа
        /// </summary>
        /// <param name="Question"></param>
        private void True(Question Question)
        {
            if (Question.True != -1)
            {
                foreach (ViewAnswer Control in listAnswers.Controls)
                {
                    if (Control.Text == Question.Answers[Question.True])
                        Control.True = true;
                }
            }
        }

        /// <summary>
        /// Отрисовывает элемент управления <see cref="ListBox"/>
        /// </summary>
        /// <param name="_control"></param>
        private void OnStyleListBox(ListBox _control)
        {
            Boolean Moving = false; Int32 SelectIndex = -1;
            Stopwatch SW = new Stopwatch();

            _control.BackColor = _control.Parent.BackColor;
            _control.BorderStyle = BorderStyle.None;
            _control.ItemHeight = 70; //80;
            _control.DrawMode = DrawMode.OwnerDrawVariable;

            _control.DrawItem += delegate (Object _object, DrawItemEventArgs _drawItemEventArgs)
            {
                if (_drawItemEventArgs.Index < 0) return;

                // Отрисовка выделения Item
                if ((_drawItemEventArgs.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    _drawItemEventArgs = new DrawItemEventArgs(
                        _drawItemEventArgs.Graphics,
                        _drawItemEventArgs.Font,
                        _drawItemEventArgs.Bounds,
                        _drawItemEventArgs.Index,
                        _drawItemEventArgs.State ^ DrawItemState.Selected,
                        _drawItemEventArgs.ForeColor,
                        Color.FromArgb(36, 119, 206));
                }

                _drawItemEventArgs.DrawBackground();
                //_drawItemEventArgs.DrawFocusRectangle();

                Rectangle BoundsQuestion = new Rectangle(31, _drawItemEventArgs.Bounds.Y + 5, _drawItemEventArgs.Bounds.Width - 31 - 10, _drawItemEventArgs.Bounds.Height - 11);
                _drawItemEventArgs.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(250, 250, 250)), BoundsQuestion);
                _drawItemEventArgs.Graphics.DrawRectangle(new Pen(Color.Gray, 1), BoundsQuestion);

                // Отрисовка номера вопроса
                TextRenderer.DrawText(
                    _drawItemEventArgs.Graphics,
                    (_drawItemEventArgs.Index + 1).ToString(),
                    new Font(Font.FontFamily, 6.5F, FontStyle.Bold),
                    new Rectangle(0, _drawItemEventArgs.Bounds.Y, 30, _drawItemEventArgs.Bounds.Height - 1),
                    Color.Black,
                    Color.Transparent,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                // Отрисовка текства вопроса
                TextRenderer.DrawText(
                    _drawItemEventArgs.Graphics,
                    /*_control.Items[_drawItemEventArgs.Index].ToString()*/ _survey.Questions[_drawItemEventArgs.Index].Name,
                    new Font(Font.FontFamily, 5.5F, FontStyle.Regular),
                    BoundsQuestion,
                    Color.Black,
                    Color.Transparent,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis | TextFormatFlags.LeftAndRightPadding);
            };
            _control.MouseDown += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                try
                {
                    if (_mouseEventArgs.Button == MouseButtons.Right)
                    {
                        _control.SelectedIndex = (_mouseEventArgs.Y / _control.ItemHeight <= _control.Items.Count) ? (_mouseEventArgs.Y / _control.ItemHeight) : _control.SelectedIndex;
                    }
                }
                catch { }

                if (_control.SelectedIndex > -1)
                {
                    Moving = true;
                    SelectIndex = _control.SelectedIndex;
                    SW.Start();
                }
            };
            _control.MouseUp += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                if (Moving && SelectIndex > -1 && SW.ElapsedMilliseconds > 100L && _control.SelectedIndex != SelectIndex)
                {
                    String _tempListQuestionView = _control.Items[SelectIndex].ToString();
                    _control.Items.RemoveAt(SelectIndex);
                    if (_control.SelectedIndex < SelectIndex)
                    {
                        _control.Items.Insert(_control.SelectedIndex, _tempListQuestionView);

                        _rewrite = false;
                        _control.SelectedIndex = _control.SelectedIndex - 1;
                    }
                    else
                    {
                        _control.Items.Insert(_control.SelectedIndex + 1, _tempListQuestionView);

                        _rewrite = false;
                        _control.SelectedIndex = _control.SelectedIndex + 1;
                    }

                    Question _tempQuestion = _survey.Questions[SelectIndex];
                    _survey.Questions.RemoveAt(SelectIndex);
                    _survey.Questions.Insert(_control.SelectedIndex, _tempQuestion);

                    _rewrite = false;
                    listQuestions_SelectedIndexChanged(_object, _mouseEventArgs);

                    SelectIndex = -1;
                    Moving = false;
                }
                SW.Stop();
                SW.Reset();
            };
            _control.KeyDown += delegate (Object _object, KeyEventArgs _keyEventArgs)
            {
                switch (_keyEventArgs.KeyCode)
                {
                    case Keys.Enter:
                        _survey.Questions.Insert(listQuestions.SelectedIndex + 1, new Question("Выбор одного правильного ответа", "", -1, null, new String[] { "", "" }));
                        listQuestions.Items.Insert(listQuestions.SelectedIndex + 1, "");

                        listQuestions.SelectedIndex = listQuestions.SelectedIndex + 1;
                        break;

                    case Keys.Delete:
                        mDelQuestion_Click(_object, _keyEventArgs);
                        break;

                    default: break;
                }
            };
        }

        #endregion

        #region Menu

        private Boolean CheckSave()
        {
            //if (!(_survey.Questions.Count == 1 && _survey.Questions[0].Name == "" && _survey.Questions[0].Answers.Count == 2 && _survey.Questions[0].Answers[0] == ""))

            if (_survey.Questions.Count == 1)
            {

            }

            if (_survey.Questions.Count > 1)
            {

            }

            return true;
        }

        // Создание теста
        private void mCreate_Click(Object sender, EventArgs e)
        {
            // Функция создания нового теста
            void Create()
            {
                listQuestions.Items.Clear();
                listQuestions.Items.Add("");

                _survey = new Survey();
                _survey.Questions.Add(new Question("Выбор одного правильного ответа", "", -1, null, new String[] { "", "" }));

                Update(_survey.Questions[0]);

                _rewrite = true;
                listQuestions.SelectedIndex = 0;
            };

            if (!(_survey.Questions.Count == 1 && _survey.Questions[0].Name == "" && _survey.Questions[0].Answers.Count == 2 && _survey.Questions[0].Answers[0] == ""))
            {
                DialogResult DR = MessageBox.Show("Сохранить изменения прошлого созданного теста?", "Конструктор тестов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (DR)
                {
                    case DialogResult.Yes:
                        mSave_Click(sender, e);
                        break;

                    case DialogResult.No:
                        Create();
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else { Create(); }
        }

        // Открытие теста
        private void mOpen_Click(Object sender, EventArgs e)
        {
            void Open()
            {
                OpenFileDialog OFD = new OpenFileDialog
                {
                    Title = "Открытие теста",
                    Filter = "Файл теста (*.xml, *.json)|*.xml; *.json"
                };

                if (DialogResult.OK == OFD.ShowDialog())
                {
                    try
                    {
                        _survey = new Survey(OFD.FileName);
                        _file = OFD.FileName;

                        listQuestions.Items.Clear();

                        foreach (Question Question in _survey.Questions)
                            listQuestions.Items.Add(Question.Name);

                        _rewrite = false;
                        listQuestions.SelectedIndex = 0;
                    }
                    catch (Exception Error) { MessageBox.Show(Error.Message, "Ошибка"); }
                }
            };

            if (!(_survey.Questions.Count == 1 && _survey.Questions[0].Name == "" && _survey.Questions[0].Answers.Count == 2 && _survey.Questions[0].Answers[0] == ""))
            {
                DialogResult DR = MessageBox.Show("Сохранить изменения прошлого созданного теста?", "Конструктор тестов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (DR)
                {
                    case DialogResult.Yes:
                        mSave_Click(sender, e);
                        break;

                    case DialogResult.No:
                        Open();
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else { Open(); }
        }

        // Сохранение теста
        private void mSave_Click(Object sender, EventArgs e)
        {
            listQuestions_SelectedIndexChanged(sender, e);

            if (_file == "")
            {
                SaveFileDialog SFD = new SaveFileDialog
                {
                    Title = "Сохранение теста",
                    Filter = "Файл теста (*.xml)|*.xml|Файл теста (*.json)|*.json",
                    FileName = _survey.Name
                };

                if (DialogResult.OK == SFD.ShowDialog())
                {
                    _survey.Save(SFD.FileName);
                    _file = SFD.FileName;
                }
            }
            else { _survey.Save(_file); }
        }
        private void mSaveAs_Click(Object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog
            {
                Title = "Сохранение теста",
                Filter = "Файл теста (*.xml)|*.xml|Файл теста (*.json)|*.json",
                FileName = _survey.Name
            };

            if (DialogResult.OK == SFD.ShowDialog())
            {
                _survey.Save(SFD.FileName);
                _file = SFD.FileName;
            }
        }

        // Автосохранение теста
        private void mAutosave_Click(Object sender, EventArgs e)
        {
            if (!mAutosave.Checked)
            {
                mAutosave.Checked = true;
                Settings.Default.AutoSave = true;
                tAutosave.Start();
            }
            else
            {
                mAutosave.Checked = false;
                Settings.Default.AutoSave = false;
                tAutosave.Stop();
            }

            Settings.Default.Save();
        }
        private void tAutosave_Tick(Object sender, EventArgs e)
        {
            if (_file != "")
                _survey.Save(_file);
        }

        // Интервал автосохранения
        private void mIntervalAutoSave5_Click(Object sender, EventArgs e)
        {
            tAutosave.Interval = 300000;
            mIntervalAutoSave5.Checked = true;
            mIntervalAutoSave10.Checked = false;
            mIntervalAutoSave30.Checked = false;

            Settings.Default.IntervalAutoSave = 5;
            Settings.Default.Save();
        }
        private void mIntervalAutoSave10_Click(Object sender, EventArgs e)
        {
            tAutosave.Interval = 600000;
            mIntervalAutoSave5.Checked = false;
            mIntervalAutoSave10.Checked = true;
            mIntervalAutoSave30.Checked = false;

            Settings.Default.IntervalAutoSave = 10;
            Settings.Default.Save();
        }
        private void mIntervalAutoSave30_Click(Object sender, EventArgs e)
        {
            tAutosave.Interval = 1800000;
            mIntervalAutoSave5.Checked = false;
            mIntervalAutoSave10.Checked = false;
            mIntervalAutoSave30.Checked = true;

            Settings.Default.IntervalAutoSave = 30;
            Settings.Default.Save();
        }

        // Выход из программы
        private void mExit_Click(Object sender, EventArgs e)
        {
            if (!(_survey.Questions.Count == 1 && _survey.Questions[0].Name == "" && _survey.Questions[0].Answers.Count == 2 && _survey.Questions[0].Answers[0] == ""))
            {
                DialogResult DR = MessageBox.Show("Сохранить изменения прошлого созданного теста?", "Конструктор тестов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (DR)
                {
                    case DialogResult.Yes:
                        mSave_Click(sender, e);
                        Application.Exit();
                        break;

                    case DialogResult.No:
                        Application.Exit();
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else { Application.Exit(); }
        }
        private void menuClose_Click(Object sender, EventArgs e)
        {
            if (!(_survey.Questions.Count == 1 && _survey.Questions[0].Name == "" && _survey.Questions[0].Answers.Count == 2 && _survey.Questions[0].Answers[0] == ""))
            {
                DialogResult DR = MessageBox.Show("Сохранить изменения прошлого созданного теста?", "Конструктор тестов", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (DR)
                {
                    case DialogResult.Yes:
                        mSave_Click(sender, e);
                        Application.Exit();
                        break;

                    case DialogResult.No:
                        Application.Exit();
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else { Application.Exit(); }
        }

        // Вызов диалога свойств теста
        private void mInformation_Click(Object sender, EventArgs e)
        {
            FormDescription FD = new FormDescription();
            Information Information = FD.Edit(new Information(_survey.Name, _survey.Description, _survey.Author));

            _survey.Name = Information.Name;
            _survey.Description = Information.Description;
            _survey.Author = Information.Author;
        }

        // Добавление вопроса
        private void mAddQuestion_Click(Object sender, EventArgs e)
        {
            _survey.Questions.Add(new Question());
            listQuestions.Items.Add("");

            listQuestions.SelectedIndex = listQuestions.Items.Count - 1;
        }

        // Дублирование вопроса
        private void mDuplicateQuestion_Click(Object sender, EventArgs e)
        {
            _survey.Questions.Insert(listQuestions.SelectedIndex + 1, _survey.Questions[listQuestions.SelectedIndex]);
            listQuestions.Items.Insert(listQuestions.SelectedIndex + 1, "");

            listQuestions.SelectedIndex = listQuestions.SelectedIndex + 1;
        }

        // Удаление вопроса
        private void mDelQuestion_Click(Object sender, EventArgs e)
        {
            if (listQuestions.Items.Count > 1)
            {
                Int32 Index = listQuestions.SelectedIndex;
                if (Index != listQuestions.Items.Count - 1)
                {
                    listQuestions.Items.RemoveAt(Index);
                    _survey.Questions.RemoveAt(Index);

                    _rewrite = false;
                    listQuestions.SelectedIndex = Index;
                }
                else
                {
                    listQuestions.Items.RemoveAt(Index);
                    _survey.Questions.RemoveAt(Index);

                    _rewrite = false;
                    listQuestions.SelectedIndex = Index - 1;
                }
            }
        }

        // Добавление картинки в вопрос
        private void mAddImage_Click(Object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Title = "Добавление изображения",
                Filter = "Изображение (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg"
            };

            if (DialogResult.OK == OFD.ShowDialog())
            {
                pImage.Image = new Bitmap(OFD.FileName);
                _survey.Questions[listQuestions.SelectedIndex].Image = new Bitmap(OFD.FileName);

                pImage.Visible = true;
                pictureBox1.Visible = true;
            }
        }
        private void mDelImage_Click(Object sender, EventArgs e)
        {
            if (_survey.Questions[listQuestions.SelectedIndex].Image != null)
            {
                _survey.Questions[listQuestions.SelectedIndex].Image = null;
                pImage.Image.Dispose();

                pImage.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        // Случайный порядок ответов
        private void mRandomOrderAnswers_Click(Object sender, EventArgs e)
        {
            if (_survey.Questions[listQuestions.SelectedIndex].Type == "Выбор одного правильного ответа")
            {
                String TempTrue = _survey.Questions[listQuestions.SelectedIndex].Answers[_survey.Questions[listQuestions.SelectedIndex].True];
                _survey.Questions[listQuestions.SelectedIndex].Answers.Shuffle();
                _survey.Questions[listQuestions.SelectedIndex].True = _survey.Questions[listQuestions.SelectedIndex].Answers.IndexOf(TempTrue);

                _rewrite = false;
                listQuestions_SelectedIndexChanged(sender, e);
            }
        }

        // Изменение типа вопроса
        private void mSingleAnswerSelection_Click(Object sender, EventArgs e)
        {
            mSingleAnswerSelection.Checked = true;
            mFreeAnswer.Checked = false;

            _survey.Questions[listQuestions.SelectedIndex].Type = mSingleAnswerSelection.Text;
            Update(_survey.Questions[listQuestions.SelectedIndex]);
        }
        private void mFreeAnswer_Click(Object sender, EventArgs e)
        {
            mSingleAnswerSelection.Checked = false;
            mFreeAnswer.Checked = true;

            _survey.Questions[listQuestions.SelectedIndex].Type = mFreeAnswer.Text;
            Update(_survey.Questions[listQuestions.SelectedIndex]);
        }

        // О программе
        private void mAboutTheProgram_Click(Object sender, EventArgs e)
        {
            FormAbout FA = new FormAbout();
            FA.ShowDialog();
        }
        private void mDeveloper_Click(Object sender, EventArgs e)
        {
            try
            {
                Process.Start(Resources.Developer);
            }
            catch { MessageBox.Show("Отсутствует подключение к интернету.", "Конструктор тестов", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        private void Designer_Load(Object sender, EventArgs e)
        {
            // Создание первого вопроса
            listQuestions.Items.Add("");
            _survey.Questions.Add(new Question("Выбор одного правильного ответа", "", -1, null, new String[] { "", "" }));

            Update(_survey.Questions[0]);

            _rewrite = true;
            listQuestions.SelectedIndex = 0;

            // Настройка автосохранения теста
            if (Settings.Default.AutoSave)
                mAutosave_Click(sender, e);

            switch (Settings.Default.IntervalAutoSave)
            {
                case 5:
                    mIntervalAutoSave5.Checked = true;
                    mIntervalAutoSave5_Click(sender, e);
                    break;

                case 10:
                    mIntervalAutoSave10.Checked = true;
                    mIntervalAutoSave10_Click(sender, e);
                    break;

                case 30:
                    mIntervalAutoSave30.Checked = true;
                    mIntervalAutoSave30_Click(sender, e);
                    break;
            }

            tQuestion.Focus();
        }

        // Выбор вопроса
        private void listQuestions_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (_currentIndex >= 0) _previousIndex = _currentIndex;
            _currentIndex = listQuestions.SelectedIndex;

            try
            {
                if (_rewrite)
                {
                    _survey.Questions[_previousIndex].Answers.Clear();
                    _survey.Questions[_previousIndex].Type = (mSingleAnswerSelection.Checked) ? mSingleAnswerSelection.Text : mFreeAnswer.Text;
                    foreach (ViewAnswer Answer in listAnswers.Controls)
                    {
                        _survey.Questions[_previousIndex].Answers.Add(Answer.Text);

                        if (Answer.True)
                            _survey.Questions[_previousIndex].True = (_survey.Questions[_previousIndex].Type == mSingleAnswerSelection.Text)
                                ? _survey.Questions[_previousIndex].Answers.IndexOf(Answer.Text)
                                : -1;
                    }
                }

                Update(_survey.Questions[listQuestions.SelectedIndex]);
            }
            catch { }

            _rewrite = true;
            tQuestion.Focus();
        }
        private void tQuestion_TextChanged(Object sender, EventArgs e)
        {
            if (listQuestions.SelectedIndex > -1)
                _survey.Questions[listQuestions.SelectedIndex].Name = tQuestion.Text;
        }

        // Добавление варианта ответа и картинки
        private void addAnswer_Click(Object sender, EventArgs e)
        {
            _survey.Questions[listQuestions.SelectedIndex].Answers.Add("");

            ViewAnswer viewAnswer = new ViewAnswer
            {
                Text = "",
                Size = new Size(panel2.Width, 69),
                Location = new Point(0, listAnswers.Controls[listAnswers.Controls.Count - 1].Location.Y + 80),
                Margin = new Padding(0, 0, 0, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                //TabIndex = i + 2,

                Name = "pAnswer" + _survey.Questions[listQuestions.SelectedIndex].Answers.Count.ToString(),
                Parent = listAnswers,
            };

            foreach (Control Control in listAnswers.Controls)
            {
                if (Control is ViewAnswer)
                {
                    (Control as ViewAnswer).TrueChanged += delegate (Object _object, EventArgs _eventArgs)
                    {
                        foreach (ViewAnswer Answer in listAnswers.Controls)
                        {
                            if (Answer.Name != Control.Name)
                                Answer.True = (Control as ViewAnswer).True ? false : true;
                        }
                    };

                    (Control as ViewAnswer).True = false;
                }
            }
        }
        private void addImage_Click(Object sender, EventArgs e)
        {
            mAddImage_Click(sender, e);
        }
    }
}
