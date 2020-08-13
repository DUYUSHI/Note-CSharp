>VSCode是一款非常强大的工具，博主也是非常喜欢这款工具，写前端和PHP时都是使用VSCode。昨晚有个小伙伴半夜打QQ电话问我，VScode调试C语言时候出错了，总是调试不好。问我有没有解决办法，具体出现的问题有下面两种！

##出现的问题

- 检测到 #include 错误。请更新 includePath。已为此翻译单元(C:\\...\main.c)
- 调试出现:Unable to start debugging. Unexpected GDB output from command"-environment-cd

##解决办法（检查到 #include 错误...）

1. 首先第一个问题，这问题我也没遇见过，但是看提示，顶多也就是没配置好文件罢了
   [![VScode检查到#include错误](https://www.yuzmboy.cn/images/202008/1d5356c6783146d5ea42f866d10332e5.jpg "VScode检查到#include错误")](https://www.yuzmboy.cn/images/202008/1d5356c6783146d5ea42f866d10332e5.jpg "VScode检查到#include错误")

2. 然后`win + r`键直接调出并打开`cmd`窗口，执行命令`g++ -v -E -x c++ -`，查看g++包含路径
   [![打开CMD窗口输出路径](https://www.yuzmboy.cn/images/202008/efd4090377368e9a343cbfbc1f4ad2f0.jpg "打开CMD窗口输出路径")](https://www.yuzmboy.cn/images/202008/efd4090377368e9a343cbfbc1f4ad2f0.jpg "打开CMD窗口输出路径")

3. 复制相关路径，打开VSCode，按键盘上快捷键`Crtl + Shift + p`，搜索关键字`C++ Config...`，并且修改相关配置即可（部分可能会重启）
   [![修改VSCode配置](https://www.yuzmboy.cn/images/202008/3541e0cb594cb3f20092e0fbe29cc433.jpg "修改VSCode配置")](https://www.yuzmboy.cn/images/202008/3541e0cb594cb3f20092e0fbe29cc433.jpg "修改VSCode配置")

##解决办法（Unable to start...）

>这个问题在之前我的旧博客中已经提过了解决办法了，但我换博客了，那就在写一遍吧！

1. 大多数是出现以下情况，当运行自己好不容易写出来的程序时，VSCode直接给你来个提示
   [![Unable to start debugging. Unexpected GDB output from command"-environment-cd](https://www.yuzmboy.cn/images/202008/7d1535db3509ce8a10a2f96bd41fd389.jpg "Unable to start debugging. Unexpected GDB output from command"-environment-cd")](https://www.yuzmboy.cn/images/202008/7d1535db3509ce8a10a2f96bd41fd389.jpg "Unable to start debugging. Unexpected GDB output from command"-environment-cd")

1. 直接把存储项目的文件夹的`中文名称`改成`英文名称`即可
   [![解决方案](https://www.yuzmboy.cn/images/202008/1ef1c5f1e20bf8fdc47a8563441cd86e.jpg "解决方案")](https://www.yuzmboy.cn/images/202008/1ef1c5f1e20bf8fdc47a8563441cd86e.jpg "解决方案")