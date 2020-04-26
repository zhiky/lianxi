using System;
using Model;
namespace Dal
{
    public class Udal
    {
        public void DL(Umodel m) 
        {
            if (m.Uname == "" || m.Upass == "")
            {
                Console.WriteLine("账户密码不能为空");
            }
            else 
            {
                Console.WriteLine("登录成功");
            }
        }
    }
    //1说下您是怎么理解什么是第三方登录？（5分）
        //第三方更加方便快捷有利于上手
    //2您是怎么理解单点登录的请说明？（5分）
    //单点登录高效简单便于使用

}
