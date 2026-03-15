using System;

class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    // 요구사항: 배열 기반으로 관리
    private TKey[] _keys;
    private TValue[] _values;
    private int _count;

    public int Count => _count;

    public Registry(int capacity)
    {
        _keys = new TKey[capacity];
        _values = new TValue[capacity];
        _count = 0;
    }

    public void Register(TKey key, TValue value)
    {
        // 1. 이미 존재하는 키인지 확인 (덮어쓰기 로직)
        for (int i = 0; i < _count; i++)
        {
            if (_keys[i].Equals(key))
            {
                _values[i] = value; // 값 업데이트
                return; // 추가 작업 없이 종료
            }
        }

        // 2. 새 키 등록 (배열 범위 체크 생략 - 생성 시 capacity 준수 가정)
        _keys[_count] = key;
        _values[_count] = value;
        _count++;
    }

    public TValue Find(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_keys[i].Equals(key))
            {
                return _values[i]; // 찾으면 즉시 반환
            }
        }
        return default(TValue); // 없으면 기본값 반환
    }

    public bool Contains(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_keys[i].Equals(key))
            {
                return true;
            }
        }
        return false;
    }

    public void PrintAll()
    {
        for (int i = 0; i < _count; ++i)
        {
            Console.WriteLine($"[{_keys[i]}] {_values[i]}");
        }
    }
}