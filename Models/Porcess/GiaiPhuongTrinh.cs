using Microsoft.AspNetCore.Mvc;
using PhamTrungHieuBTH.Models;
namespace PhamTrungHieuBTH.Models.Process
{
  public class GiaiPhuongTrinh 
  {
    //xay dung cac phuong thuc
    public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
    {
        //khai bao 1 bien  de chua du lieu
        string message = "";
        //khai bao 1 bien so de chua gia tri
        double x;
        //Giai phuong trinh
        if(heSoA==0){
            if(heSoB==0){
                message ="Phuong trinh co vo so nghiem.";
            }
            else{
                message = "Phuong trinh vo nghiem";
            }
    
        }else{
            //tinh nghiem cua phuong trinh
            x= -heSoB/heSoA;
            message = " nghiem x= " + x;
        }
        //tra ve du lieu
        return message;
    }
    //phuong trinh bac 2
    public string GiaiPhuongTrinhBacHai(double heSoA, double heSoB,double heSoC)
    {
         //khai bao 1 bien  de chua du lieu
        string message = "";
        //khai bao 1 bien so de chua gia tri
        double x;
        double x1;
        double x2;
        double delta;
        delta = heSoB * heSoB - 4 * heSoA * heSoC ;
        if(heSoA==0)
        {
            //Giai pt bac 1
            if(heSoB ==0)
            {
                //Neu b= 0 vaf c=0 thif phuowng trinh vo so nghiem
                if(heSoC==0)
            {
                message ="Phuong trinh co vo so nghiem";
            }
            //neu b=0 va c!=0 thif vo nghiem
            else{
                message = "phuong trinh vo nghiem";
            }
            }
            else 
            {
                x1=(double)-heSoC/heSoB;
                message ="Phuong trinh co nghiem duy nhat: x={0}";
            }
            return message;
         }
        //Neu a!=0 thif bat dau bac 2
        else
        {
            // tinh delta
               delta = Math.Pow(heSoB, 2) - 4 * heSoA * heSoC;
               //Kiem tra xem <0 thif pt vo nghiem
               if(delta < 0)
               {
                message = "Phuong trinh vo nghiem.";
               }
               //neu delta = 0 thif cos nghiem kep
               else if(delta ==0)
               {
                x1=x2=-heSoB/(2*heSoA);
                message = "Phuong trinh co nghiem kep x= ";
               }
               //neu >0 thif cos nghiem phan biet
               else{
                    x1 = (-heSoB + Math.Sqrt(delta)) / (2 * heSoA);
                    x2 = (-heSoB - Math.Sqrt(delta)) / (2 * heSoA);
                   message = "Phuong trinh co 2 nghiem phan biet:";
                    message = " Nghiem x1=" +x1;
                   message = " Nghiem x2=" +x2;
               }
        }
    
        return message;
    }
  }
}