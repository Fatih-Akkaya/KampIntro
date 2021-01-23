using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            int index = FindKey(key); //Dictionary sınıfında key mevcutsa güncellenir, yoksa eklenir
            if (index>=0)
            {
                values[index] = value;
            } else //key mevcut değilse en sona ekleme yapılır
            {
                TKey[] tempKeys = keys;
                TValue[] tempValues = values;
                keys = new TKey[keys.Length + 1];
                values = new TValue[values.Length + 1];
                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                    values[i] = tempValues[i];
                }
                keys[keys.Length - 1] = key;
                values[keys.Length - 1] = value;
            }
        }

        int FindKey(TKey key)
        {
            for (int k=0;k<keys.Length;k++)
            {
                if(keys[k].Equals(key))
                {
                    return k; //key bulundu                    
                }
            }
            return -1; //key bulunamadı
        }
        public int Count
        {
            get
            {
                return keys.Length;
            }
        }
        public TKey Key(int index)
        {
            return keys[index];
        }

        public TValue Value(int index)
        {
            return values[index];
        }
    }
}
