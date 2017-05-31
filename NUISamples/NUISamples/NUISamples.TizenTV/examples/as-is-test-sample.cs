using System;
using Tizen.NUI.BaseComponents;
using Tizen.NUI;

namespace TizenSTVUIApplication15
{
    class Program : NUIApplication
    {
        private Timer myTimer;

        private View myView;
        private TextLabel myTextLabel;


        //===========================
        Layer layer;
        View vi1, vi2, vi3;
        TextLabel tl1, tl2, tl3;
        ToggleButton tb1, tb2, tb3;


        protected override void OnCreate()
        {
            base.OnCreate();

            myView = new View();
            myView.Size = new Size(100, 100, 0);
            myView.Position = new Position(100, 100, 0);
            myView.BackgroundColor = Color.Red;
            myView.Name = "myView";

            Window.Instance.GetDefaultLayer().Add(myView);

            myTextLabel = new TextLabel();
            myTextLabel.Position = new Position(100, 100, 0);
            myTextLabel.Size = new Size(100, 100, 0);
            myTextLabel.Name = "myTextLabel";

            myView.Add(myTextLabel);

            //===========================
            LayerTest2();

            myTimer = new Timer(500);
            myTimer.Tick += Mytimer_Tick;
            myTimer.Start();
        }

        private void ObjectDumpTrigger()
        {
            for (int i = 0; i < Window.GetLayerCount(); i++)
            {
                BFS(Window.GetLayer((uint)i), 1);
            }
        }



        private static void BFS(Animatable o, int depth)
        {
            if (o == null)
            {
                Tizen.Log.Fatal("NUI-APP", "##### o == null! return here!");
                return;
            }

            Tizen.Log.Fatal("NUI-APP", "##### o.GetTypeName()=" + o.GetTypeName());

            if (o is View)
            {
                View myView = o as View;

                if (o is TextLabel)
                {
                    TextLabel myTextLabel = o as TextLabel;

                    Tizen.Log.Fatal("NUI-APP", string.Format("it is TextLabel, {0}", myTextLabel.Text));

                    return;
                }
                else
                {
                    Tizen.Log.Fatal("NUI-APP", string.Format("it is not TextLaebl"));
                }

                for (int i = 0; i < myView.GetChildCount(); i++)
                {
                    BFS(myView.GetChildAt((uint)i), depth + 1);
                }
            }
            else if (o is Layer)
            {
                Layer myLayer = o as Layer;

                for (int i = 0; i < myLayer.GetChildCount(); i++)
                {
                    BFS(myLayer.GetChildAt((uint)i), depth + 1);
                }
            }
            else
            {
                return;
            }
        }

        private bool Mytimer_Tick(object source, Timer.TickEventArgs e)
        {
            //ObjectDumpTrigger();
            ObjectDumpTrigger2();

            return true;
        }



        //======================================================================
        void LayerTest2()
        {
            layer = new Layer();

            vi1 = new View();
            vi2 = new View();
            vi3 = new View();

            tl1 = new TextLabel();
            tl2 = new TextLabel();
            tl3 = new TextLabel();

            tb1 = new ToggleButton();
            tb2 = new ToggleButton();
            tb3 = new ToggleButton();

            vi1.Add(vi3);
            vi1.Add(tl1);
            vi1.Add(tl2);

            vi3.Add(tb1);
            vi3.Add(tb2);

            vi2.Add(tl3);

            layer.Add(vi1);
            layer.Add(vi2);
            layer.Add(tb3);

            Window.Instance.AddLayer(layer);
        }

        void ObjectDumpTrigger2()
        {
            uint layerCnt = Window.GetLayerCount();
            Tizen.Log.Fatal("NUI-APP", "layerCnt=" + layerCnt);

            for (uint i = 0; i < layerCnt; i++)
            {
                Tizen.Log.Fatal("NUI-APP", "T[" + DateTime.Now + "]__________ layer #" + i + " traverse");
                CheckViewsInLayer(Window.GetLayer(i));
            }
        }
        void CheckViewsInLayer(Animatable obj)
        {
            if (obj is Layer)
            {
                var layer = obj as Layer;
                if (layer == null)
                {
                    Tizen.Log.Fatal("NUI-APP", "### layer is null! just return!");
                    return;
                }
                uint childCnt = layer.GetChildCount();
                if (childCnt > 0)
                {
                    for (uint i = 0; i < childCnt; i++)
                    {
                        var temp = layer.GetChildAt(i) as View;
                        Tizen.Log.Fatal("NUI-APP", "depth[1] child in layer! type=" + temp?.GetTypeName());
                        ViewCheckRecurse(temp, 1);
                    }
                }
                else
                {
                    Tizen.Log.Fatal("NUI-APP", "### there is no child in this layer! just return!");
                }
            }
            else
            {
                Tizen.Log.Fatal("NUI-APP", "obj is NOT Layer! do nothing!");
            }
        }
        void ViewCheckRecurse(View view, int depth)
        {
            if (view)
            {
                uint childCnt = view.GetChildCount();
                if (childCnt > 0)
                {
                    depth = depth + 1;
                    for (uint i = 0; i < childCnt; i++)
                    {
                        var temp = view.GetChildAt(i) as View;
                        Tizen.Log.Fatal("NUI-APP", "depth[" + depth + "] child in layer! type=" + temp.GetTypeName() + " AS-IS Test: IsView?=" + (temp is View) + " IsTextLabel?=" + (temp is TextLabel) );
                        ViewCheckRecurse(temp, depth);
                    }
                }
                else
                {
                    //Tizen.Log.Fatal("NUI-APP", "depth[" + depth + "] child in layer! type=" + view.GetTypeName());
                    return;
                }
            }
            else
            {
                //Tizen.Log.Fatal("NUI-APP", "### view is null! just return!");
            }
        }

        private static void _Main(string[] args)
        {
            //Create an Application
            Program myProgram = new Program();
            myProgram.Run(args);
        }
    }
}