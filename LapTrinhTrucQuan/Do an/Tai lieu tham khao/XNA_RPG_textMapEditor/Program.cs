using System;
///
/// XNA_RPG textMapEditor engine duoc viet boi HuyetSat - Xvna.forumb.biz
/// Moi cap nhat hay thac mac � kien ve engine xin li�n he tai: xvna.forumb.biz hoac thanh_vinh648@yahoo.com
/// Engine ho�n to�n free v� n� cho ph�p c�c ban ph�t trien RPG mot c�ch de d�ng!
/// Yeu cau ghi ro~ nguon goc engine va tac gia khi ban phat trien game ca nhan bang engine nay!
/// Ch�n th�nh cam an ban d� quan t�m su dung engine n�y!
///
namespace XNA_RPG_textMapEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (RPG game = new RPG())
            {
                game.Run();
            }
        }
    }
}

