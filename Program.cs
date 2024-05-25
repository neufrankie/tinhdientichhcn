using System;

namespace TinhDienTichHinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap chieu rong tu ban phim
            Console.Write("Nhap vao chieu rong cua hinh chu nhat: ");
            double chieuRong = Convert.ToDouble(Console.ReadLine());

            // Nhap chieu dai tu ban phim
            Console.Write("Nhap vao chieu dai cua hinh chu nhat: ");
            double chieuCao = Convert.ToDouble(Console.ReadLine());

            // Tinh dien tich cua hinh chu nhat
            double dienTich = chieuRong * chieuCao;

            // Hien thi ket qua
            Console.WriteLine("Dien tich cua hinh chu nhat do la: " + dienTich);
        }
    }
}
