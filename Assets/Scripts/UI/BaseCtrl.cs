using System;

public class BaseCtrl<T> where T : BaseCtrl<T>, new()
{
    private static T instance = null;
    protected static readonly object lockObject = new object();

    protected BaseCtrl()
    {
    }
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = Activator.CreateInstance<T>();
                    }
                }
            }
            return instance;
        }
    }

    public virtual void Init()
    {

    }

    public virtual void Release()
    {

    }

    public virtual void Update()
    {
        
    }
}