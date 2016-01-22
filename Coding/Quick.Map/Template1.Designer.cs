﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quick.Map {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Template {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Template() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Quick.Map.Template", typeof(Template).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;h1&gt;Quick.Map帮助&lt;/h1&gt;
        ///&lt;br/&gt;
        ///&lt;p&gt;默认情况下，显示选中文本的地图信息&lt;/p&gt;
        ///&lt;p&gt;参数 &lt;strong&gt;m&lt;/strong&gt; (&lt;strong&gt;map&lt;/strong&gt;) [&lt;em&gt;width&lt;/em&gt;] [&lt;em&gt;height&lt;/em&gt;] 获得一张此地址的静态地图图片，将其放入剪切板并插入至文档。width和height为可选参数，表示需要插入地图的大小，取值范围为1~1024，如超出此范围，会得到一张空白的图片。默认大小为400*300。&lt;/p&gt;
        ///&lt;p&gt;参数 &lt;strong&gt;v&lt;/strong&gt; (&lt;strong&gt;view&lt;/strong&gt;)，获得一张此地址的全景图片（如果有的话），将其放入剪切板并插入至文档。width和height为可选参数，表示需要插入地图的大小，width取值范围为10~4096，height取值范围为10~512，如超出此范围，会得到一张空白的图片。默认大小为512*256。如果图片尺寸太大，可能无法获取到该区域的全景图。&lt;/p&gt;
        ///&lt;br/&gt;
        ///&lt;p&gt;例如：&lt;strong&gt;@map m 500 600&lt;/strong&gt; 可以插入一张500*6 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string help {
            get {
                return ResourceManager.GetString("help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        ///&lt;title&gt;Quick Map&lt;/title&gt;
        ///&lt;script type=&quot;text/javascript&quot; src=&quot;http://api.map.baidu.com/api?v=1.5&amp;amp;ak=${ak}&quot;&gt;&lt;/script&gt;
        ///&lt;script src=&quot;http://d1.lashouimg.com/static/js/release/jquery-1.4.2.min.js&quot; type=&quot;text/javascript&quot;&gt;&lt;/script&gt;
        ///&lt;style type=&quot;text/css&quot;&gt;
        ///    html,body,#container{
        ///        width:${width}px;
        ///        height:${height}px;
        ///    }
        ///    html,body{
        ///        margin:0;
        ///        overflow:hidden;
        ///        backgroun [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string htmlTemplate {
            get {
                return ResourceManager.GetString("htmlTemplate", resourceCulture);
            }
        }
    }
}
