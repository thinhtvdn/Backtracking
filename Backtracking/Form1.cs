using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Có 5 căn hộ, 
Phòng thì có tên và có kệ để khóa (khóa khác nhau với tên), 
dùng thuật toán quay lui để mình họa việc tìm chìa khóa c#
*/


namespace Backtracking
{
    public partial class Form1 : Form
    {
        List<string> rooms;
        List<string> keysInRooms;
        string keyToFind;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool found = FindKey(rooms, keysInRooms, keyToFind, 0);
            if (found)
            {
               MessageBox.Show("Đã tìm thấy chìa khóa!");
            }
            else
            {
                MessageBox.Show("Chìa khóa không có!");
            }
        }
        static bool FindKey(List<string> rooms, List<string> keys, string keyToFind, int index)
        {
            // Nếu đã kiểm tra hết các phòng
            if (index >= rooms.Count)
            {
                return false;
            }

            // Kiểm tra chìa khóa trong phòng hiện tại
            MessageBox.Show($"Kiểm tra {rooms[index]}: {keys[index]}");
            if (keys[index] == keyToFind)
            {
                return true; // Nếu tìm thấy chìa khóa
            }

            // Tiến hành kiểm tra phòng tiếp theo, tìm không thấy thì quay lui, tìm phòng khác
            return FindKey(rooms, keys, keyToFind, index + 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rooms = new List<string> { "Phòng A", "Phòng B", "Phòng C", "Phòng D", "Phòng E" };
            keysInRooms = new List<string>
            {
                "Chìa khóa 1", // Phòng A
                "Chìa khóa 2", // Phòng B
                "Chìa khóa 3", // Phòng C
                "Chìa khóa 4", // Phòng D
                "Chìa khóa 5"  // Phòng E
            };
            keyToFind = "Chìa khóa 3"; // Giả sử chìa khóa cần tìm là Chìa khóa 3

        }
    }
}
