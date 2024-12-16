/*
Дана строка s, которая содержит только символы '(', ')', '{', '}', '[' и ']'.
Требуется определить является ли строка валидной.
Входная строка является валидной, если:
● открытая скобка закрыта скобкой того же типа,
● все скобки закрыты в порядке открытия,
● все скобки закрытия имеют соответствующую скобку открытия.

Ограничения:
● 1 <= s.Length <= 10000
● строка s состоит только из символов ‘(){}[]’
Шаблон кода:
*/



public static class Solution
{
    private static Stack<char> stack = new Stack<char>();

    public static bool IsValid(string s)
    { 
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }      
            else
            {
                if (stack.Count == 0) return false;
                
                var ss = stack.Pop();
                switch (ss)
                {
                    case '(':
                        if (c == ')') { continue; }
                        break;
                    case '{':
                        if (c == '}') continue;
                        break;
                    case '[':
                        if (c == ']') continue;
                        break;
                    default:
                        break;
                }
                return false;
            }         
        }

        if (stack.Count > 0) { return false; }

        return true;
    }
}

