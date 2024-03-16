namespace MOD4_1302220080
{
    public class Program
    {
        public enum namaBuah
        {apel, aprikot, alpukat, pisang, paprika, blackberry, ceri, kelapa, jagung, kurma, durian, anggur, melon, semangka}

        public static string getKodeBuah(namaBuah namaBuah)
        {
            string[] kodeBuah = { "A00, B00, C00, D00, E00, F00, H00, I00, J00, K00, L00, M00, N00, O00" };
            return kodeBuah[(int)namaBuah];            
        }
        
        static void Main(string[] args)
        {
            namaBuah namaBuah = new namaBuah();

            Console.WriteLine("Nama buah: " + namaBuah + kodeBuah);
        }

    }
}
