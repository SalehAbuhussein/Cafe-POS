using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cafe_Management_System.Global_Classes
{
    public class clsUtil
    {
        public static bool CreateFolderIfNotExist(string folderName)
        {
            try
            {
                if (!File.Exists(folderName))
                {
                    Directory.CreateDirectory(folderName);
                    return true;
                } else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return false;
        }

        // Write Username and password on remember-me.txt
        public static bool SaveUsernameAndPassword(string username, string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\Software\CafeManagementSystem";

            try
            {
                Registry.SetValue(keyPath, "Username", username, RegistryValueKind.String);
                Registry.SetValue(keyPath, "Password", password, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error has occured! => {ex.Message}");
            }

            return false;
        }

        public static bool GetStoredUsernameAndPassword(ref string username, ref string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\Software\CafeManagementSystem";

            try
            {
                username = Registry.GetValue(keyPath, "Username", "") as string;
                password = Registry.GetValue(keyPath, "Password", "") as string;

                return true;
            } catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong => {ex.Message}");
            }

            return false;
        }

        public static void SetupGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(38, 38, 38);

            dgv.RowTemplate.Height = 40;

            dgv.GridColor = Color.FromArgb(50, 50, 50);

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.RowHeadersVisible = false;

            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dgv.ReadOnly = true;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void ApplyRoundedCorners(int radius, Form frm)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(frm.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(frm.Width - radius, frm.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, frm.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            frm.Region = new Region(path);
        }

        public static bool IsNumberInput(KeyPressEventArgs e, string currentText, bool allowDecimal = false)
        {
            char pressedKey = e.KeyChar;
            return char.IsControl(pressedKey) || char.IsDigit(pressedKey) || (allowDecimal && pressedKey == '.' && !currentText.Trim().Contains("."));
        }

        public static bool IsSpecialCharacter(KeyPressEventArgs e)
        {
            return !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    
        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }  
    }
}
