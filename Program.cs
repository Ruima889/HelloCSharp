using System;
 
 Console.WriteLine("--- 欢迎进入 C# 入门练习 ---");
 Console.WriteLine("1. 用户交互测试");
 Console.WriteLine("2. 成绩评级测试");
 Console.WriteLine("3. 九九乘法表测试");
 
 Console.Write("请输入你想运行的练习编号 (1-3): ");
 string choice = Console.ReadLine();
 
 if (choice == "1")
 {
     // 运行交互测试
     InteractionTest();
 }
 else if (choice == "2")
 {
     // 运行成绩评级
     GradeTest();
 }
 else if (choice == "3")
 {
     // 运行九九乘法表
     MultiplicationTest();
 }
 else
 {
     Console.WriteLine("无效的编号，程序退出。");
 }

 