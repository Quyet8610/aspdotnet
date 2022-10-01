namespace aspdotnet.Moldels

{
    public class GiaiPhuongTrinh
    {
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
            string ketqua = "";
            if(heSoA==0)
            {
                ketqua = "Phuong Trinh Vo Nghiem";
            } else {
                ketqua = $"Phuong Tring Co Nghiem,{-heSoB/heSoA}";
            }
            return ketqua ;

        }

        public string GiaiPhuongTrinhBacHai(double heSoA, double heSoB, double heSoC)
        {
            return "";
        }
        
    }
}
