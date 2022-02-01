using System;

namespace tugasRPLNilaiAkhir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipe Data
            string? nama;
            double? nis, nAbsen, nTugas, nUts, nUas, jnAbsen, jnTugas, jnUts, jnUas, hasil;

            // Input dan Output
            
            Console.WriteLine("\n======================================");
            Console.Write("\nNIS : ");
            nis = double.Parse(Console.ReadLine());

            Console.Write("Nama : ");
            nama = Console.ReadLine();

            Console.Write("Nilai Absen : ");
            nAbsen = double.Parse(Console.ReadLine());

            Console.Write("Nilai Tugas : ");
            nTugas = double.Parse(Console.ReadLine());

            Console.Write("Nilai UTS : ");
            nUts = double.Parse(Console.ReadLine());

            Console.Write("Nilai UAS : ");
            nUas = double.Parse(Console.ReadLine());

            // Convert

            jnAbsen = Convert.ToDouble(nAbsen);
            jnTugas = Convert.ToDouble(nTugas);
            jnUts = Convert.ToDouble(nUts);
            jnUas = Convert.ToDouble(nUas);

            // Penjumlahan
            
            hasil = (jnAbsen * 10 / 100) + (jnTugas * 20 / 100) + (jnUts * 30 / 100) +
            (jnUas * 40 / 100);
            
            // Print Nilai
            
            Console.WriteLine("Nilai Akhir : " + hasil);

            // Ranking
            
            Console.WriteLine("\n======================================\n");
            if (hasil >= 80)
            {
                Console.WriteLine("Ranking Anda 'A'");
            }
            else if (hasil >= 70)
            {
                Console.WriteLine("Ranking Anda 'B'");
            }
            else if (hasil >= 60)
            {
                Console.WriteLine("Ranking Anda 'C'");
            }
            else if (hasil >= 50)
            {
                Console.WriteLine("Ranking 'E'");
            }
            else
            {
                Console.WriteLine("Ranking 'F'");
            }
        }
    }
}
