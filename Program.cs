using System;

class SinhVien
{
    public string MaSV;
    public string HoTen;
    public double Diem;

    public SinhVien(string maSV, string hoTen, double diem)
    {
        MaSV = maSV;
        HoTen = hoTen;
        Diem = diem;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong sinh vien n = ");
        int n = int.Parse(Console.ReadLine());

        SinhVien[] ds = new SinhVien[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap sinh vien thu {i + 1}:");

            Console.Write("Ma SV: ");
            string maSV = Console.ReadLine();

            Console.Write("Ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Diem: ");
            double diem = double.Parse(Console.ReadLine());

            ds[i] = new SinhVien(maSV, hoTen, diem);
        }
        double tong = 0;

        for (int i = 0; i < n; i++)
        {
            tong += ds[i].Diem;
        }

        double diemTB = tong / n;

        Console.WriteLine($"\n3. Diem trung binh = {diemTB:F2}");
        double diemMax = ds[0].Diem;

        for (int i = 1; i < n; i++)
        {
            if (ds[i].Diem > diemMax)
            {
                diemMax = ds[i].Diem;
            }
        }

        Console.WriteLine($"4. Diem cao nhat = {diemMax:F2}");
        int soLuongDat = 0;

        for (int i = 0; i < n; i++)
        {
            if (ds[i].Diem >= 5)
            {
                soLuongDat++;
            }
        }

        Console.WriteLine($"5. So luong sinh vien dat = {soLuongDat}");
        Console.WriteLine("\n6. BANG DANH SACH SINH VIEN");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("{0,-10} {1,-25} {2,10}", "Ma SV", "Ho Ten", "Diem");
        Console.WriteLine("----------------------------------------------------");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0,-10} {1,-25} {2,10:F2}",
                ds[i].MaSV,
                ds[i].HoTen,
                ds[i].Diem);
        }

        Console.WriteLine("----------------------------------------------------");
    }
}