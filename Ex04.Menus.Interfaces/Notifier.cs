using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class Notifier
    {
        private List<IDoActionListener> m_Listeners;

        public Notifier()
        {
            m_Listeners = new List<IDoActionListener>();
        }

        public void AddListener(IDoActionListener i_Listener)
        {
            m_Listeners.Add(i_Listener);
        }

        public void RemoveListener(IDoActionListener i_Listener)
        {
            m_Listeners.Remove(i_Listener);
        }

        public void NotifiyAll()
        {
            foreach (IDoActionListener actionListener in m_Listeners)
            {
                actionListener.DoAction();
            }
        }
    }
}