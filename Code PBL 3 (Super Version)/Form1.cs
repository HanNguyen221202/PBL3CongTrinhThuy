using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace Code_PBL_3__Super_Version_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int OriginX = 250;
        private int OriginY = 300;

        private void ptbBanvedap_Paint(object sender, PaintEventArgs e)
        {

            string fileexcel = txtLink.Text;

            // Kiểm tra xem TextBox có trống hay không
            if (string.IsNullOrWhiteSpace(fileexcel))
            {
                MessageBox.Show("Vui lòng nhập đường dẫn đến tệp Excel !", "Error");
                return;
            }

            // Kiểm tra xem đường dẫn có hợp lệ hay không
            if (!System.IO.File.Exists(fileexcel))
            {
                MessageBox.Show("Đường dẫn không hợp lệ hoặc tệp không tồn tại !", "Error");
                return;
            }

            Graphics g = e.Graphics;
            Pen blackpen = new Pen(Color.Black);
            // Vẽ trục Ox
            g.DrawLine(blackpen, OriginX, OriginY, 1040, OriginY);

            System.Drawing.Font arialfont = new System.Drawing.Font("Arial", 8);
            Brush blackbrush = new SolidBrush(Color.Black);

            for (int i = OriginX; i <= 1040; i += 40)
            {
                g.DrawLine(blackpen, i, OriginY - 5, i, OriginY + 5);
                g.DrawString(((i - OriginX) / 2).ToString(), arialfont, blackbrush, i - 10, OriginY + 10);
            }

            System.Drawing.Point point1 = new System.Drawing.Point(1055, OriginY);
            System.Drawing.Point point2 = new System.Drawing.Point(1040, OriginY - 5);
            System.Drawing.Point point3 = new System.Drawing.Point(1040, OriginY + 5);
            // Tạo một mảng điểm cho tam giác
            System.Drawing.Point[] trianglePoints1 = { point1, point2, point3 };
            // Vẽ tam giác
            g.DrawPolygon(blackpen, trianglePoints1);
            //Định nghĩa màu sắc cho tam giác
            Color fillColor1 = Color.Black;
            Brush brush1 = new SolidBrush(fillColor1);
            g.FillPolygon(brush1, trianglePoints1);

            blackpen.Dispose();
            arialfont.Dispose();
            blackbrush.Dispose();
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {

            System.Drawing.Font arialfont = new System.Drawing.Font("Arial", 8);
            System.Drawing.Font tnrfont = new System.Drawing.Font("Times New Roman", 11);
            Brush blackbrush = new SolidBrush(Color.Black);

            string fileexcel = txtLink.Text;
 
            // Khởi tạo ứng dụng Excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            try
            {
                // Mở Workbook từ tệp Excel
                Excel.Workbook workbook = excelApp.Workbooks.Open(fileexcel);

                // Lấy giá trị từ ô 1A
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Sheet 1
                Excel.Range cellF5 = worksheet.Range["F5"];
                float Hcodap = Convert.ToSingle(cellF5.Value) * 2;
                Excel.Range cellB3 = worksheet.Range["B3"];
                float Daydap = Convert.ToSingle(cellB3.Value);
                Excel.Range cellG5 = worksheet.Range["G5"];
                float Bcodap = Convert.ToSingle(cellG5.Value) * 2;
                Excel.Range cellB5 = worksheet.Range["B5"];
                float Bdinhdap = Convert.ToSingle(cellB5.Value) * 2;
                Excel.Range cellE5 = worksheet.Range["E5"];
                float HSm13 = Convert.ToSingle(cellE5.Value);
                Excel.Range cellE6 = worksheet.Range["E6"];
                float HSm12 = Convert.ToSingle(cellE6.Value);
                Excel.Range cellE7 = worksheet.Range["E7"];
                float HSm11 = Convert.ToSingle(cellE7.Value);
                Excel.Range cellJ5 = worksheet.Range["J5"];
                float HSm21 = Convert.ToSingle(cellJ5.Value);
                Excel.Range cellJ6 = worksheet.Range["J6"];
                float HSm22 = Convert.ToSingle(cellJ6.Value);
                Excel.Range cellO5 = worksheet.Range["O5"];
                float HSTVTN = Convert.ToSingle(cellO5.Value);
                Excel.Range cellO6 = worksheet.Range["O6"];
                float HSPVTN = Convert.ToSingle(cellO6.Value);
                Excel.Range cellB11 = worksheet.Range["B11"];
                float daiSP = Convert.ToSingle(cellB11.Value) * 2;
                Excel.Range cellB12 = worksheet.Range["B12"];
                float DdauSP = Convert.ToSingle(cellB12.Value) * 2;
                Excel.Range cellB13 = worksheet.Range["B13"];
                float DcuoiSP = Convert.ToSingle(cellB13.Value) * 2;
                Excel.Range cellB16 = worksheet.Range["B16"];
                float MNDBT = Convert.ToSingle(cellB16.Value) * 2;
                Excel.Range cellB17 = worksheet.Range["B17"];
                float MNLTK = Convert.ToSingle(cellB17.Value) * 2;
                Excel.Range cellB18 = worksheet.Range["B18"];
                float MNLKT = Convert.ToSingle(cellB18.Value) * 2;
                Excel.Range cellB20 = worksheet.Range["B20"];
                float MNHLBT = Convert.ToSingle(cellB20.Value) * 2;
                Excel.Range cellB21 = worksheet.Range["B21"];
                float MNHLMAX = Convert.ToSingle(cellB21.Value) * 2;
                Excel.Range cellB25 = worksheet.Range["B25"];
                float DdinhTN = Convert.ToSingle(cellB25.Value) * 2;
                Excel.Range cellB26 = worksheet.Range["B26"];
                float DdayTN = Convert.ToSingle(cellB26.Value) * 2;

                Excel.Range cellH10 = worksheet.Range["H10"];
                double Kt = Convert.ToDouble(cellH10.Value);
                Excel.Range cellH11 = worksheet.Range["H11"];
                double Kd = Convert.ToDouble(cellH11.Value);

                Graphics t = ptbBanvedap.CreateGraphics();
                Pen blackpen = new Pen(Color.Black);
                Pen bluepen = new Pen(Color.Blue);
                Pen redpen = new Pen(Color.Red);

                //vẽ sân phủ
                float x15 = OriginX + DdauSP * HSm13;
                float y15 = OriginY - DdauSP;

                float x16 = OriginX - daiSP;
                float y16 = OriginY - DcuoiSP;
                t.DrawLine(blackpen, x15, y15, x16, y16);

                t.DrawLine(blackpen, x16, y16, x16, OriginY);

                t.DrawLine(blackpen, x16, OriginY, OriginX, OriginY);

                float x1 = OriginX + HSm13 * Hcodap;
                float y1 = (OriginY - Hcodap);
                t.DrawLine(blackpen, x15, y15, x1, y1);

                float x2 = x1 + Bcodap;
                t.DrawLine(blackpen, x1, y1, x2, y1);

                float x3 = x2 + HSm12 * Hcodap;
                float y3 = (OriginY - 2 * Hcodap);
                t.DrawLine(blackpen, x2, y1, x3, y3);

                float x4 = x3 + Bcodap;
                t.DrawLine(blackpen, x3, y3, x4, y3);

                float x5 = x4 + HSm11 * Hcodap;
                float y5 = (OriginY - 3 * Hcodap);
                t.DrawLine(blackpen, x4, y3, x5, y5);

                float x6 = x5 + Bdinhdap;
                t.DrawLine(blackpen, x5, y5, x6, y5);

                float x7 = x6 + HSm21 * Hcodap;
                float y7 = y3;
                t.DrawLine(blackpen, x6, y5, x7, y7);

                float x8 = x7 + Bcodap;
                t.DrawLine(blackpen, x7, y7, x8, y7);

                float x9 = x8 + HSm22 * Hcodap;
                float y9 = y1;
                t.DrawLine(blackpen, x8, y7, x9, y9);

                float x10 = x9 + Bcodap;
                t.DrawLine(blackpen, x9, y9, x10, y9);

                float x11 = x10 + HSPVTN * Hcodap;
                float y11 = OriginY;
                t.DrawLine(blackpen, x10, y9, x11, y11);

                float x12 = x10 - HSTVTN * Hcodap;
                float y12 = OriginY;
                t.DrawLine(blackpen, x9, y9, x12, y12);

                //tô màu cho vật thoát nước
                SolidBrush brush1 = new SolidBrush(Color.Gray);
                t.FillPolygon(brush1, new System.Drawing.Point[] { new System.Drawing.Point((int)x9, (int)y9), 
                    new System.Drawing.Point((int)x10, (int)y9), new System.Drawing.Point((int)x11, (int)y11), new System.Drawing.Point((int)x12, (int)y12) });

                //vẽ tường nghiêng
                float x13 = x5 + DdinhTN;
                float x14 = OriginX + DdayTN + 30;
                t.DrawLine(blackpen, x13, y5, x14, OriginY);

                //tô màu cho tường nghiêng và sân phủ
                t.FillPolygon(brush1, new System.Drawing.Point[] { new System.Drawing.Point((int)x5, (int)y5), new System.Drawing.Point((int)x13, (int)y5),
            new System.Drawing.Point((int)x14, (int)OriginY), new System.Drawing.Point((int)OriginX, (int)OriginY), new System.Drawing.Point((int)x1, (int)y1),
            new System.Drawing.Point((int)x2, (int)y1 ), new System.Drawing.Point((int)x3, (int)y3 ), new System.Drawing.Point((int)x4, (int)y3 ) });

                t.FillPolygon(brush1, new System.Drawing.Point[] { new System.Drawing.Point((int)x15, (int)y15), new System.Drawing.Point((int)OriginX, (int)OriginY),
            new System.Drawing.Point((int)x16, (int)OriginY), new System.Drawing.Point((int)x16, (int)y16) });

                //Vẽ trục Oy
                t.DrawLine(blackpen, x16, OriginY, x16, OriginY - 120);

                t.DrawString("5", arialfont, blackbrush, x16 - 15, OriginY - 17);
                t.DrawString("10", arialfont, blackbrush, x16 - 20, OriginY - 27);
                t.DrawString("15", arialfont, blackbrush, x16 - 20, OriginY - 37);
                t.DrawString("20", arialfont, blackbrush, x16 - 20, OriginY - 47);
                t.DrawString("25", arialfont, blackbrush, x16 - 20, OriginY - 57);
                t.DrawString("30", arialfont, blackbrush, x16 - 20, OriginY - 67);
                t.DrawString("35", arialfont, blackbrush, x16 - 20, OriginY - 77);
                t.DrawString("40", arialfont, blackbrush, x16 - 20, OriginY - 87);
                t.DrawString("45", arialfont, blackbrush, x16 - 20, OriginY - 97);
                t.DrawString("50", arialfont, blackbrush, x16 - 20, OriginY - 107);
                t.DrawString("55", arialfont, blackbrush, x16 - 20, OriginY - 117);

                t.DrawLine(blackpen, x16 - 5, OriginY - 10, x16 + 5, OriginY - 10);
                t.DrawLine(blackpen, x16 - 5, OriginY - 20, x16 + 5, OriginY - 20);
                t.DrawLine(blackpen, x16 - 5, OriginY - 30, x16 + 5, OriginY - 30);
                t.DrawLine(blackpen, x16 - 5, OriginY - 40, x16 + 5, OriginY - 40);
                t.DrawLine(blackpen, x16 - 5, OriginY - 50, x16 + 5, OriginY - 50);
                t.DrawLine(blackpen, x16 - 5, OriginY - 60, x16 + 5, OriginY - 60);
                t.DrawLine(blackpen, x16 - 5, OriginY - 70, x16 + 5, OriginY - 70);
                t.DrawLine(blackpen, x16 - 5, OriginY - 80, x16 + 5, OriginY - 80);
                t.DrawLine(blackpen, x16 - 5, OriginY - 90, x16 + 5, OriginY - 90);
                t.DrawLine(blackpen, x16 - 5, OriginY - 100, x16 + 5, OriginY - 100);
                t.DrawLine(blackpen, x16 - 5, OriginY - 110, x16 + 5, OriginY - 110);

                //Vẽ tam giác kí hiệu cơ đập, đỉnh đập
                System.Drawing.Point point1 = new System.Drawing.Point((int)((x1 + x2) / 2), (int)y1);
                System.Drawing.Point point2 = new System.Drawing.Point((int)((x1 + x2) / 2 - 7), (int)y1 - 7);
                System.Drawing.Point point3 = new System.Drawing.Point((int)((x1 + x2) / 2 + 7), (int)y1 - 7);
                // Tạo một mảng điểm cho tam giác
                System.Drawing.Point[] trianglePoints1 = { point1, point2, point3 };
                // Vẽ tam giác
                t.DrawPolygon(blackpen, trianglePoints1);

                System.Drawing.Point point4 = new System.Drawing.Point((int)((x3 + x4) / 2), (int)y3);
                System.Drawing.Point point5 = new System.Drawing.Point((int)((x3 + x4) / 2 - 7), (int)y3 - 7);
                System.Drawing.Point point6 = new System.Drawing.Point((int)((x3 + x4) / 2 + 7), (int)y3 - 7);
                // Tạo một mảng điểm cho tam giác
                System.Drawing.Point[] trianglePoints2 = { point4, point5, point6 };
                // Vẽ tam giác
                t.DrawPolygon(blackpen, trianglePoints2);

                System.Drawing.Point point7 = new System.Drawing.Point((int)((x5 + x6) / 2), (int)y5);
                System.Drawing.Point point8 = new System.Drawing.Point((int)((x5 + x6) / 2 - 7), (int)y5 - 7);
                System.Drawing.Point point9 = new System.Drawing.Point((int)((x5 + x6) / 2 + 7), (int)y5 - 7);
                // Tạo một mảng điểm cho tam giác
                System.Drawing.Point[] trianglePoints3 = { point7, point8, point9 };
                // Vẽ tam giác
                t.DrawPolygon(blackpen, trianglePoints3);

                System.Drawing.Point point10 = new System.Drawing.Point((int)((x7 + x8) / 2), (int)y7);
                System.Drawing.Point point11 = new System.Drawing.Point((int)((x7 + x8) / 2 - 7), (int)y7 - 7);
                System.Drawing.Point point12 = new System.Drawing.Point((int)((x7 + x8) / 2 + 7), (int)y7 - 7);
                // Tạo một mảng điểm cho tam giác
                System.Drawing.Point[] trianglePoints4 = { point10, point11, point12 };
                // Vẽ tam giác
                t.DrawPolygon(blackpen, trianglePoints4);

                t.DrawString("Đỉnh đập " + "(" + Hcodap * 3 / 2 + " m" + ")", tnrfont, blackbrush, new PointF(x5 - 25, y5 - 30));
                t.DrawString("Cơ đập " + "(" + Hcodap / 2 + " m" + ")", tnrfont, blackbrush, new PointF(x1 - 25, y1 - 30));
                t.DrawString("Cơ đập " + "(" + Hcodap + " m" + ")", tnrfont, blackbrush, new PointF(x3 - 40, y3 - 30));
                t.DrawString("Cơ đập " + "(" + Hcodap + " m" + ")", tnrfont, blackbrush, new PointF(x7 - 20, y7 - 35));
                t.DrawString("VTN", tnrfont, blackbrush, new PointF(x10 - 20, y9 - 30));
                t.DrawString("Cao trình đáy đập = " + Daydap + " (m)", tnrfont, blackbrush, new PointF(x1, y1 + 70));

                //vẽ mũi tên trục Oy
                System.Drawing.Point point19 = new System.Drawing.Point((int)x16, OriginY - 135);
                System.Drawing.Point point20 = new System.Drawing.Point((int)x16 - 5, OriginY - 120);
                System.Drawing.Point point21 = new System.Drawing.Point((int)x16 + 5, OriginY - 120);
                // Tạo một mảng điểm cho tam giác
                System.Drawing.Point[] trianglePoints7 = { point19, point20, point21 };
                // Vẽ tam giác
                t.DrawPolygon(blackpen, trianglePoints7);
                //Định nghĩa màu sắc cho tam giác
                Color fillColor3 = Color.Black;
                Brush brush4 = new SolidBrush(fillColor3);
                t.FillPolygon(brush4, trianglePoints7);


                // Lấy giá trị từ ComboBox1
                string selectedItemComboBox1 = cbbMNTL.SelectedItem?.ToString();

                // Lấy giá trị từ ComboBox2
                string selectedItemComboBox2 = cbbMNHL.SelectedItem?.ToString();

                // Kiểm tra xem có giá trị được chọn từ cả hai ComboBox hay không
                if (string.IsNullOrEmpty(selectedItemComboBox1) || string.IsNullOrEmpty(selectedItemComboBox2))
                {
                    MessageBox.Show("Vui lòng chọn giá trị từ cả hai mực nước !", "Thông báo");
                    return;
                }

                // Thực hiện tính toán dựa trên giá trị từ cả hai ComboBox
                float MNTL = GetValueForComboBox1(selectedItemComboBox1);
                float MNHL = GetValueForComboBox2(selectedItemComboBox2);

                //vẽ mực nước thượng lưu
                float x17 = x4 + (MNTL - 2 * Hcodap) * HSm11;

                t.DrawLine(bluepen, x16 - 5, OriginY - MNTL, x17, OriginY - MNTL);

                //vẽ tam giác kí hiệu mực nước
                System.Drawing.Point point13 = new System.Drawing.Point((int)OriginX, (int)(OriginY - MNTL));
                System.Drawing.Point point14 = new System.Drawing.Point((int)(OriginX - 7), (int)(OriginY - MNTL - 7));
                System.Drawing.Point point15 = new System.Drawing.Point((int)(OriginX + 7), (int)(OriginY - MNTL - 7));
                // Tạo một mảng điểm cho tam giác
                System.Drawing.Point[] trianglePoints5 = { point13, point14, point15 };
                // Vẽ tam giác
                t.DrawPolygon(blackpen, trianglePoints5);
                Color fillColor1 = Color.Blue;
                Brush brush2 = new SolidBrush(fillColor1);
                t.FillPolygon(brush2, trianglePoints5);
                t.DrawString("Mực nước thượng lưu " + "(" + (MNTL / 2 + 0.2f) + " m)", tnrfont, blackbrush, new PointF(OriginX, OriginY - MNTL - 30));

                //vẽ mực nước hạ lưu
                float x18 = x11 - MNHL * HSPVTN;
                t.DrawLine(bluepen, x18, OriginY - MNHL, 1040 - 20, OriginY - MNHL);

                //vẽ tam giác kí hiệu mực nước
                System.Drawing.Point point16 = new System.Drawing.Point((int)x11 + 15, (int)(OriginY - MNHL));
                System.Drawing.Point point17 = new System.Drawing.Point((int)(x11 + 8), (int)(OriginY - MNHL - 7));
                System.Drawing.Point point18 = new System.Drawing.Point((int)(x11 + 22), (int)(OriginY - MNHL - 7));
                // Tạo một mảng điểm cho tam giác
                System.Drawing.Point[] trianglePoints6 = { point16, point17, point18 };
                // Vẽ tam giác
                t.DrawPolygon(blackpen, trianglePoints6);
                Color fillColor2 = Color.Blue;
                Brush brush3 = new SolidBrush(fillColor2);
                t.FillPolygon(brush3, trianglePoints6);

                t.DrawString("Mực nước hạ lưu " + "(" + (MNHL / 2 + 0.2f) + " m)", tnrfont, blackbrush, new PointF(x18, OriginY - MNHL - 30));
                blackpen.Dispose();

                //vẽ đường bão hòa
                t.DrawLine(redpen, (int)x17, OriginY - MNTL, (int)x17 - 10, OriginY - MNTL + 3);

                List<System.Drawing.Point> controlPoints = new List<System.Drawing.Point>();

                controlPoints.Add(new System.Drawing.Point((int)x17 - 10, (int)(OriginY - MNTL + 3)));
                controlPoints.Add(new System.Drawing.Point((int)(x17 + x18) / 2 - 65, (int)(OriginY - MNTL + OriginY - MNHL) / 2));
                controlPoints.Add(new System.Drawing.Point((int)x18 - 60, (int)(OriginY - MNHL - 3)));
                controlPoints.Add(new System.Drawing.Point((int)x18, (int)(OriginY - MNHL)));
                t.DrawCurve(redpen, controlPoints.ToArray());

                //tính toán số hóa
                float h1;
                float L = (x18 - x17) / 2;
                float denta = HSm12 / (1 + 2 * HSm12);
                float lamda = 0.447f;
                float sinalpha = 0.228f;
                float z0 = 0.802f;

                for (h1 = 0; h1 < 50; h1 += 0.001f)
                {
                    double leftside = Kt * (double)((Math.Pow(MNTL / 2, 2) - Math.Pow(h1, 2) - Math.Pow(z0, 2)) / (2 * denta * sinalpha)); 
                    double rightside = Kd * (double)((Math.Pow(h1, 2) - Math.Pow(MNHL / 2, 2)) / (2 * (L + lamda * h1)));
                    if (Math.Abs(leftside - rightside) < 0.001)
                    {
                        txtChieucaoh1.Text = h1.ToString();
                        txtLuuluongq.Text = leftside.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            finally
            {
                // Giải phóng tài nguyên COM
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ptbBanvedap.Invalidate();
        }

        private int GetValueForComboBox1(string selectedItem)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;
            string fileexcel = txtLink.Text;
            Excel.Workbook workbook = excelApp.Workbooks.Open(fileexcel);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            Excel.Range cellB16 = worksheet.Range["B16"];
            float MNDBT = Convert.ToSingle(cellB16.Value) * 2;
            Excel.Range cellB17 = worksheet.Range["B17"];
            float MNLTK = Convert.ToSingle(cellB17.Value) * 2;
            Excel.Range cellB18 = worksheet.Range["B18"];
            float MNLKT = Convert.ToSingle(cellB18.Value) * 2;
            
            switch (selectedItem)
            {
                case "MNDBT":
                    return (int)MNDBT;
                case "MNLTK":
                    return (int)MNLTK;
                case "MNLKT":
                    return (int)MNLKT;
                default:
                    return 0;
            }
        }

        private int GetValueForComboBox2(string selectedItem)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;
            string fileexcel = txtLink.Text;
            Excel.Workbook workbook = excelApp.Workbooks.Open(fileexcel);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            Excel.Range cellB20 = worksheet.Range["B20"];
            float MNHLBT = Convert.ToSingle(cellB20.Value) * 2;
            Excel.Range cellB21 = worksheet.Range["B21"];
            float MNHLMAX = Convert.ToSingle(cellB21.Value) * 2;

            switch (selectedItem)
            {
                case "MNHLBT":
                    return (int)MNHLBT;
                case "MNHL MAX":
                    return (int)MNHLMAX;
                default:
                    return 0;
            }
        }

        private void btnDrawSlide_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;
            string fileexcel = txtLink.Text;
            Excel.Workbook workbook = excelApp.Workbooks.Open(fileexcel);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            Excel.Range cellF5 = worksheet.Range["F5"];
            float Hcodap = Convert.ToSingle(cellF5.Value) * 2;
            Excel.Range cellG5 = worksheet.Range["G5"];
            float Bcodap = Convert.ToSingle(cellG5.Value) * 2;
            Excel.Range cellB5 = worksheet.Range["B5"];
            float Bdinhdap = Convert.ToSingle(cellB5.Value) * 2;
            Excel.Range cellE5 = worksheet.Range["E5"];
            float HSm13 = Convert.ToSingle(cellE5.Value);
            Excel.Range cellE6 = worksheet.Range["E6"];
            float HSm12 = Convert.ToSingle(cellE6.Value);
            Excel.Range cellE7 = worksheet.Range["E7"];
            float HSm11 = Convert.ToSingle(cellE7.Value);
            Excel.Range cellJ5 = worksheet.Range["J5"];
            float HSm21 = Convert.ToSingle(cellJ5.Value);
            Excel.Range cellJ6 = worksheet.Range["J6"];
            float HSm22 = Convert.ToSingle(cellJ6.Value);
            Excel.Range cellO6 = worksheet.Range["O6"];
            float HSPVTN = Convert.ToSingle(cellO6.Value);
            Excel.Range cellB3 = worksheet.Range["B3"];
            float Daydap = Convert.ToSingle(cellB3.Value);

            string selectedItemComboBox3 = cbbMatcat.SelectedItem?.ToString();
            float Matcat = GetValueForComboBox3(selectedItemComboBox3) - Daydap;
            Pen blackpen = new Pen(Color.Black);
            Pen bluepen = new Pen(Color.Blue);
            Pen redpen = new Pen(Color.Red);
            System.Drawing.Font tnrfont = new System.Drawing.Font("Times New roman", 11);
            Graphics t = ptbBanvedap.CreateGraphics();

            float x1 = OriginX + HSm13 * Hcodap;
            float y1 = (OriginY - Hcodap);
            float x2 = x1 + Bcodap;
            float x3 = x2 + HSm12 * Hcodap;
            float y3 = (OriginY - 2 * Hcodap);
            float x4 = x3 + Bcodap;
            float x5 = x4 + HSm11 * Hcodap;
            float y5 = (OriginY - 3 * Hcodap);
            float x6 = x5 + Bdinhdap;
            float x7 = x6 + HSm21 * Hcodap;
            float y7 = y3;
            float x8 = x7 + Bcodap;
            float x9 = x8 + HSm22 * Hcodap;
            float y9 = y1;
            float x10 = x9 + Bcodap;
            float x11 = (HSPVTN * (Hcodap / 2 - Matcat) * 2);
            float x12 = x8 + (HSm22 * (Hcodap - Matcat) * 2);
            float x13 = ((Matcat - Hcodap) * 2 * HSm11);
            float x14 = ((Matcat - Hcodap) * 2 * HSm21);

            if (Matcat < (Hcodap / 2))
            {
                t.DrawLine(blackpen, OriginX + HSm13 * Matcat * 2, OriginY - Matcat * 2, x1, y1);
                t.DrawLine(blackpen, x1, y1, x2, y1);
                t.DrawLine(blackpen, x2, y1, x3, y3);
                t.DrawLine(blackpen, x3, y3, x4, y3);
                t.DrawLine(blackpen, x4, y3, x5, y5);
                t.DrawLine(blackpen, x5, y5, x6, y5);
                t.DrawLine(blackpen, x6, y5, x7, y7);
                t.DrawLine(blackpen, x7, y7, x8, y7);
                t.DrawLine(blackpen, x8, y7, x9, y9);
                t.DrawLine(blackpen, x9, y9, x10, y9);
                t.DrawLine(blackpen, x10, y9, x10 + x11, OriginY - Matcat * 2);
                t.DrawLine(blackpen, OriginX + HSm13 * Matcat * 2, OriginY - Matcat * 2, OriginX + HSm13 * Matcat * 2, OriginY);
                t.DrawLine(blackpen, x10 + x11, OriginY - Matcat * 2, x10 + x11, OriginY);
                t.DrawLine(blackpen, OriginX + HSm13 * Matcat * 2, OriginY - Matcat * 2, x10 + x11, OriginY - Matcat * 2);
                t.DrawString(Matcat + " (m)", tnrfont, Brushes.Black, OriginX - 15, OriginY - Matcat - 5);
                float d1 = x10 + x11 - (OriginX + HSm13 * Matcat * 2);
                float d2 = (x10 - x1) / 2;
                float d3 = (x8 - x3) / 2;
                float S1 = (d1 + d2) * Hcodap / 2 / 2;
                float S2 = (Bdinhdap / 2 + d2) * Hcodap / 2 * 3 / 2;
                float S3 = (d2 + d3) / 2;
                float S4 = S1 + S2 + S3;
                txtDientich.Text = S4.ToString();
            }    
            
            else if (Matcat == Hcodap / 2)
            {
                t.DrawLine(blackpen, x1, y1, x2, y1);
                t.DrawLine(blackpen, x2, y1, x3, y3);
                t.DrawLine(blackpen, x3, y3, x4, y3);
                t.DrawLine(blackpen, x4, y3, x5, y5);
                t.DrawLine(blackpen, x5, y5, x6, y5);
                t.DrawLine(blackpen, x6, y5, x7, y7);
                t.DrawLine(blackpen, x7, y7, x8, y7);
                t.DrawLine(blackpen, x8, y7, x9, y9);
                t.DrawLine(blackpen, x9, y9, x10, y9);
                t.DrawLine(blackpen, x1, y1, x1, OriginY);
                t.DrawLine(blackpen, x10, y9, x10, OriginY);
                t.DrawLine(blackpen, x1, y1, x10, y9);
                t.DrawString(Matcat + " (m)", tnrfont, Brushes.Black, x1 - 50, y1 - 5);
                float d1 = (x10 - x1) / 2;
                float d2 = (x8 - x3) / 2;
                float S1 = (d1 + d2) * Hcodap / 2 / 2;
                float S2 = (Bdinhdap / 2 + d2) * Hcodap / 2 * 3 / 2;
                float S3 = S1 + S2;
                txtDientich.Text = S3.ToString();
            }
            else if (Matcat > Hcodap / 2 && Matcat < Hcodap)
            {
                t.DrawLine(blackpen, x2 + (Matcat - Hcodap / 2) * 2 * HSm12, OriginY - Matcat * 2, x3, y3);
                t.DrawLine(blackpen, x3, y3, x4, y3);
                t.DrawLine(blackpen, x4, y3, x5, y5);
                t.DrawLine(blackpen, x5, y5, x6, y5);
                t.DrawLine(blackpen, x5, y5, x6, y5);
                t.DrawLine(blackpen, x6, y5, x7, y7);
                t.DrawLine(blackpen, x7, y7, x8, y7);
                t.DrawLine(blackpen, x8, y7, x12, OriginY - Matcat * 2);
                t.DrawLine(blackpen, x2 + (Matcat - Hcodap / 2) * 2 * HSm12, OriginY - Matcat * 2, x2 + (Matcat - Hcodap / 2) * 2 * HSm12, OriginY);
                t.DrawLine(blackpen, x12, OriginY - Matcat * 2, x12, OriginY);
                t.DrawLine(blackpen, x2 + (Matcat - Hcodap / 2) * 2 * HSm12, OriginY - Matcat * 2, x12, OriginY - Matcat * 2);
                t.DrawString(Matcat + " (m)", tnrfont, Brushes.Black, x1 + 25, y1 - 25);
                float d1 = (x12 - (x2 + (Matcat - Hcodap / 2) * 2 * HSm12)) / 2;
                float d2 = (x8 - x3) / 2;
                float S1 = (d1 + d2) * (Hcodap - Matcat) / 2;
                float S2 = (d2 + Bdinhdap / 2) * (Hcodap / 2) / 2;
                float S3 = S1 + S2;
                txtDientich.Text = S3.ToString();
            }   
            
            else if (Matcat > Hcodap)
            {
                t.DrawLine(blackpen, x4 + x13, OriginY - Matcat * 2, x5, y5);
                t.DrawLine(blackpen, x5, y5, x6, y5);
                t.DrawLine(blackpen, x6, y5, x7 - x14, OriginY - Matcat * 2);
                t.DrawLine(blackpen, x4 + x13, OriginY - Matcat * 2, x4 + x13, OriginY);
                t.DrawLine(blackpen, x7 - x14, OriginY - Matcat * 2, x7 - x14, OriginY);
                t.DrawLine(blackpen, x4 + x13, OriginY - Matcat * 2, x7 - x14, OriginY - Matcat * 2);
                t.DrawString(Matcat + " (m)", tnrfont, Brushes.Black, x4 - 20, OriginY - Matcat * 2);
                float d1 = ((x7 - x14) - (x4 + x13)) / 2;
                float S1 = ((d1 + Bdinhdap / 2) * (Hcodap / 2 * 3 - Matcat)) / 2;
                txtDientich.Text = S1.ToString();
            }
        }
        private int GetValueForComboBox3(string selectedItem)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;
            string fileexcel = txtLink.Text;
            Excel.Workbook workbook = excelApp.Workbooks.Open(fileexcel);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            Excel.Range cellE12 = worksheet.Range["E12"];
            float mcH2 = Convert.ToSingle(cellE12.Value);
            Excel.Range cellE13 = worksheet.Range["E13"];
            float mcH3 = Convert.ToSingle(cellE13.Value);
            Excel.Range cellE14 = worksheet.Range["E14"];
            float mcH4 = Convert.ToSingle(cellE14.Value);
            Excel.Range cellE15 = worksheet.Range["E15"];
            float mcH5 = Convert.ToSingle(cellE15.Value);
            Excel.Range cellE16 = worksheet.Range["E16"];
            float mcH6 = Convert.ToSingle(cellE16.Value);
            Excel.Range cellE17 = worksheet.Range["E17"];
            float mcH7 = Convert.ToSingle(cellE17.Value);
            Excel.Range cellE18 = worksheet.Range["E18"];
            float mcH8 = Convert.ToSingle(cellE18.Value);
            Excel.Range cellE19 = worksheet.Range["E19"];
            float mcH9 = Convert.ToSingle(cellE19.Value);
            Excel.Range cellE20 = worksheet.Range["E20"];
            float mcH10 = Convert.ToSingle(cellE20.Value);
            Excel.Range cellE21 = worksheet.Range["E21"];
            float mcH1 = Convert.ToSingle(cellE21.Value);

            switch (selectedItem)
            {
                case "Mặt cắt 2":
                    return (int)mcH2;
                case "Mặt cắt 3":
                    return (int)mcH3;
                case "Mặt cắt 4":
                    return (int)mcH4;
                case "Mặt cắt 5":
                    return (int)mcH5;
                case "Mặt cắt 6":
                    return (int)mcH6;
                case "Mặt cắt 7":
                    return (int)mcH7;
                case "Mặt cắt 8":
                    return (int)mcH8;
                case "Mặt cắt 9":
                    return (int)mcH9;
                case "Mặt cắt 10":
                    return (int)mcH10;
                case "Mặt cắt 1":
                    return (int)mcH1;
                default:
                    return 0;
            }
        }
        private void btnChonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog getPath = new OpenFileDialog();
            getPath.Filter = "Text files (*.xlsx)|*.*";
            if (getPath.ShowDialog() == DialogResult.OK)
            {
                txtLink.Text = getPath.FileName;
            }
        }
    }
}


