import java.util.*;

public class StringTasks {

    // ==================== 1-10. Основные методы класса String ====================

    // 1. Длина, первый и последний символ (с обработкой пустой строки)
    static void task1(String s) {
        System.out.println("Длина: " + s.length());
        if (s.isEmpty()) {
            System.out.println("Строка пустая — нет первого и последнего символа.");
        } else {
            System.out.println("Первый символ: " + s.charAt(0));
            System.out.println("Последний символ: " + s.charAt(s.length() - 1));
        }
    }

    // 2. Верхний и нижний регистр
    static void task2(String s) {
        System.out.println("Верхний: " + s.toUpperCase());
        System.out.println("Нижний: " + s.toLowerCase());
    }

    // 3. Удаление пробелов в начале и конце
    static void task3(String s) {
        System.out.println("Обрезано: '" + s.trim() + "'");
    }

    // 4. Проверка префикса и суффикса
    static void task4(String s, String prefix, String suffix) {
        System.out.println("Начинается с '" + prefix + "': " + s.startsWith(prefix));
        System.out.println("Заканчивается на '" + suffix + "': " + s.endsWith(suffix));
    }

    // 5. Замена всех вхождений символа
    static void task5(String s, char from, char to) {
        System.out.println("Результат: " + s.replace(from, to));
    }

    // 6. Количество вхождений символа
    static int task6(String s, char c) {
        int count = 0;
        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) == c) count++;
        }
        return count;
    }

    // 7. Индексы первого и последнего вхождения подстроки
    static void task7(String s, String sub) {
        System.out.println("Первый индекс: " + s.indexOf(sub));
        System.out.println("Последний индекс: " + s.lastIndexOf(sub));
    }

    // 8. Содержит ли слово без учёта регистра
    static boolean task8(String s, String word) {
        return s.toLowerCase().contains(word.toLowerCase());
    }

    // 9. Сравнение без учёта регистра
    static boolean task9(String a, String b) {
        return a.equalsIgnoreCase(b);
    }

    // 10. Убрать лишние пробелы между словами
    static String task10(String s) {
        String trimmed = s.trim();
        StringBuilder sb = new StringBuilder();
        boolean prevSpace = false;
        for (int i = 0; i < trimmed.length(); i++) {
            char c = trimmed.charAt(i);
            if (c == ' ') {
                if (!prevSpace) sb.append(c);
                prevSpace = true;
            } else {
                sb.append(c);
                prevSpace = false;
            }
        }
        return sb.toString();
    }

    // ==================== 11-20. Обработка символов и подстрок ====================

    // 11. Разворот строки без готового метода
    static String task11(String s) {
        StringBuilder sb = new StringBuilder();
        for (int i = s.length() - 1; i >= 0; i--) {
            sb.append(s.charAt(i));
        }
        return sb.toString();
    }

    // 12. Палиндром без учёта регистра и пробелов
    static boolean task12(String s) {
        String cleaned = s.toLowerCase().replace(" ", "");
        String reversed = task11(cleaned);
        return cleaned.equals(reversed);
    }

    // 13. Первые N символов с проверкой
    static String task13(String s, int n) {
        if (n < 0 || n > s.length()) {
            return "Недопустимое N";
        }
        return s.substring(0, n);
    }

    // 14. Подстрока между индексами с проверкой
    static String task14(String s, int start, int end) {
        if (start < 0 || end > s.length() || start > end) {
            return "Недопустимые индексы";
        }
        return s.substring(start, end);
    }

    // 15. Удалить все пробелы
    static String task15(String s) {
        return s.replace(" ", "");
    }

    // 16. Удалить все цифры
    static String task16(String s) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (!Character.isDigit(c)) sb.append(c);
        }
        return sb.toString();
    }

    // 17. Оставить только буквы и пробелы
    static String task17(String s) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (Character.isLetter(c) || c == ' ') sb.append(c);
        }
        return sb.toString();
    }

    // 18. Свести повторяющиеся пробелы к одному (без regex) — аналог task10
    static String task18(String s) {
        return task10(s);
    }

    // 19. Все индексы заданного символа
    static List<Integer> task19(String s, char c) {
        List<Integer> result = new ArrayList<>();
        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) == c) result.add(i);
        }
        return result;
    }

    // 20. Разделить строку пополам (при нечётной — первая короче)
    static String[] task20(String s) {
        int mid = s.length() / 2;
        return new String[]{s.substring(0, mid), s.substring(mid)};
    }

    // ==================== 21-30. Слова и предложения ====================

    // 21. Количество слов (несколько пробелов)
    static int task21(String s) {
        String cleaned = task10(s);
        if (cleaned.isEmpty()) return 0;
        return cleaned.split(" ").length;
    }

    // 22. Самое длинное слово (при равенстве — первое)
    static String task22(String s) {
        String[] words = task10(s).split(" ");
        String longest = "";
        for (String w : words) {
            if (w.length() > longest.length()) longest = w;
        }
        return longest;
    }

    // 23. Самое короткое слово (без пустых)
    static String task23(String s) {
        String[] words = task10(s).split(" ");
        String shortest = null;
        for (String w : words) {
            if (w.isEmpty()) continue;
            if (shortest == null || w.length() < shortest.length()) shortest = w;
        }
        return shortest;
    }

    // 24. Каждое слово с заглавной буквы
    static String task24(String s) {
        String[] words = task10(s).split(" ");
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < words.length; i++) {
            String w = words[i];
            if (w.isEmpty()) continue;
            sb.append(Character.toUpperCase(w.charAt(0)));
            sb.append(w.substring(1).toLowerCase());
            if (i < words.length - 1) sb.append(" ");
        }
        return sb.toString();
    }

    // 25. Слова, начинающиеся с заданной буквы (без учёта регистра)
    static int task25(String s, char letter) {
        String[] words = task10(s).split(" ");
        int count = 0;
        for (String w : words) {
            if (!w.isEmpty() && Character.toLowerCase(w.charAt(0)) == Character.toLowerCase(letter)) count++;
        }
        return count;
    }

    // 26. Количество предложений по . ! ?
    static int task26(String s) {
        int count = 0;
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (c == '.' || c == '!' || c == '?') count++;
        }
        return count;
    }

    // 27. Слова в обратном порядке
    static String task27(String s) {
        String[] words = task10(s).split(" ");
        StringBuilder sb = new StringBuilder();
        for (int i = words.length - 1; i >= 0; i--) {
            sb.append(words[i]);
            if (i > 0) sb.append(" ");
        }
        return sb.toString();
    }

    // 28. Самое частое слово (при равенстве — первое встретившееся)
    static String task28(String s) {
        String[] words = task10(s).toLowerCase().split(" ");
        Map<String, Integer> map = new LinkedHashMap<>();
        for (String w : words) {
            if (w.isEmpty()) continue;
            map.put(w, map.getOrDefault(w, 0) + 1);
        }
        String best = null;
        int max = 0;
        for (Map.Entry<String, Integer> e : map.entrySet()) {
            if (e.getValue() > max) {
                max = e.getValue();
                best = e.getKey();
            }
        }
        return best;
    }

    // 29. Уникальные ли слова (без учёта регистра)
    static boolean task29(String s) {
        String[] words = task10(s).toLowerCase().split(" ");
        Set<String> set = new HashSet<>();
        for (String w : words) {
            if (w.isEmpty()) continue;
            if (!set.add(w)) return false;
        }
        return true;
    }

    // 30. Сократить до N символов с многоточием
    static String task30(String s, int n) {
        if (s.length() <= n) return s;
        if (n <= 3) return s.substring(0, n);
        return s.substring(0, n - 3) + "...";
    }

    // ==================== 31-40. Поиск, сравнение, преобразование ====================

    // 31. Анаграммы (без учёта регистра и пробелов)
    static boolean task31(String a, String b) {
        char[] x = a.toLowerCase().replace(" ", "").toCharArray();
        char[] y = b.toLowerCase().replace(" ", "").toCharArray();
        Arrays.sort(x);
        Arrays.sort(y);
        return Arrays.equals(x, y);
    }

    // 32. Самый длинный общий префикс
    static String task32(String a, String b) {
        int min = Math.min(a.length(), b.length());
        int i = 0;
        while (i < min && a.charAt(i) == b.charAt(i)) i++;
        return a.substring(0, i);
    }

    // 33. Самая длинная общая подстрока
    static String task33(String a, String b) {
        String best = "";
        for (int i = 0; i < a.length(); i++) {
            for (int j = i + 1; j <= a.length(); j++) {
                String sub = a.substring(i, j);
                if (b.contains(sub) && sub.length() > best.length()) best = sub;
            }
        }
        return best;
    }

    // 34. Неперекрывающиеся вхождения подстроки
    static int task34(String s, String sub) {
        int count = 0;
        int idx = 0;
        while ((idx = s.indexOf(sub, idx)) != -1) {
            count++;
            idx += sub.length();
        }
        return count;
    }

    // 35. Заменить только первое вхождение
    static String task35(String s, String from, String to) {
        int idx = s.indexOf(from);
        if (idx == -1) return s;
        return s.substring(0, idx) + to + s.substring(idx + from.length());
    }

    // 36. Удалить все вхождения подстроки
    static String task36(String s, String sub) {
        return s.replace(sub, "");
    }

    // 37. Сравнение версий по числовым компонентам
    static int task37(String v1, String v2) {
        String[] a = v1.split("\\.");
        String[] b = v2.split("\\.");
        int len = Math.max(a.length, b.length);
        for (int i = 0; i < len; i++) {
            int x = i < a.length ? Integer.parseInt(a[i]) : 0;
            int y = i < b.length ? Integer.parseInt(b[i]) : 0;
            if (x != y) return Integer.compare(x, y);
        }
        return 0;
    }

    // 38. Сортировка имён без учёта регистра
    static String[] task38(String[] names) {
        String[] copy = names.clone();
        Arrays.sort(copy, String.CASE_INSENSITIVE_ORDER);
        return copy;
    }

    // 39. Слова, содержащие подстроку, без повторений
    static Set<String> task39(String s, String sub) {
        String[] words = task10(s).split(" ");
        Set<String> result = new LinkedHashSet<>();
        for (String w : words) {
            if (w.toLowerCase().contains(sub.toLowerCase())) result.add(w);
        }
        return result;
    }

    // 40. Можно ли получить вторую строку удалением ровно одного символа
    static boolean task40(String a, String b) {
        if (a.length() - b.length() != 1) return false;
        int i = 0, j = 0;
        boolean skipped = false;
        while (i < a.length() && j < b.length()) {
            if (a.charAt(i) == b.charAt(j)) {
                i++; j++;
            } else {
                if (skipped) return false;
                skipped = true;
                i++;
            }
        }
        return true;
    }

    // ==================== 41-50. Форматирование и проверка данных ====================

    // 41. Простой email
    static boolean task41(String email) {
        int at = email.indexOf('@');
        if (at <= 0 || at != email.lastIndexOf('@')) return false;
        if (at == email.length() - 1) return false;
        String domain = email.substring(at + 1);
        return domain.contains(".");
    }

    // 42. Телефон +7 и 10 цифр (разрешены пробелы и дефисы)
    static boolean task42(String phone) {
        String cleaned = phone.replace(" ", "").replace("-", "");
        if (!cleaned.startsWith("+7")) return false;
        String digits = cleaned.substring(2);
        if (digits.length() != 10) return false;
        for (int i = 0; i < digits.length(); i++) {
            if (!Character.isDigit(digits.charAt(i))) return false;
        }
        return true;
    }

    // 43. Пароль: >=8, заглавная, строчная, цифра
    static boolean task43(String p) {
        if (p.length() < 8) return false;
        boolean upper = false, lower = false, digit = false;
        for (int i = 0; i < p.length(); i++) {
            char c = p.charAt(i);
            if (Character.isUpperCase(c)) upper = true;
            else if (Character.isLowerCase(c)) lower = true;
            else if (Character.isDigit(c)) digit = true;
        }
        return upper && lower && digit;
    }

    // 44. 'Имя Фамилия' -> 'Фамилия, И.'
    static String task44(String fullName) {
        String[] parts = task10(fullName).split(" ");
        if (parts.length < 2) return fullName;
        return parts[1] + ", " + Character.toUpperCase(parts[0].charAt(0)) + ".";
    }

    // 45. Разряды числа: '1234567' -> '1 234 567'
    static String task45(String num) {
        StringBuilder sb = new StringBuilder();
        int count = 0;
        for (int i = num.length() - 1; i >= 0; i--) {
            sb.append(num.charAt(i));
            count++;
            if (count % 3 == 0 && i > 0) sb.append(" ");
        }
        return sb.reverse().toString();
    }

    // 46. Только цифры (без parseInt)
    static boolean task46(String s) {
        if (s.isEmpty()) return false;
        for (int i = 0; i < s.length(); i++) {
            if (!Character.isDigit(s.charAt(i))) return false;
        }
        return true;
    }

    // 47. 'дд-мм-гггг' -> 'гггг/мм/дд'
    static String task47(String date) {
        String[] parts = date.split("-");
        if (parts.length != 3) return "Неверный формат";
        if (parts[0].length() != 2 || parts[1].length() != 2 || parts[2].length() != 4) return "Неверный формат";
        for (String p : parts) {
            if (!task46(p)) return "Неверный формат";
        }
        return parts[2] + "/" + parts[1] + "/" + parts[0];
    }

    // 48. Нормализация имени пользователя
    static String task48(String s) {
        return task10(s);
    }

    // 49. Идентификатор Java
    static boolean task49(String s) {
        if (s.isEmpty()) return false;
        char first = s.charAt(0);
        if (!(Character.isLetter(first) || first == '_' || first == '$')) return false;
        for (int i = 1; i < s.length(); i++) {
            char c = s.charAt(i);
            if (!(Character.isLetterOrDigit(c) || c == '_' || c == '$')) return false;
        }
        return true;
    }

    // 50. Домен из URL
    static String task50(String url) {
        String s = url;
        if (s.startsWith("https://")) s = s.substring(8);
        else if (s.startsWith("http://")) s = s.substring(7);
        if (s.startsWith("www.")) s = s.substring(4);
        int slash = s.indexOf('/');
        if (slash != -1) s = s.substring(0, slash);
        return s;
    }

    // ==================== 51-60. Комплексные задания ====================

    // 51. Статистика по тексту
    static void task51(String s) {
        int letters = 0, digits = 0, spaces = 0, punct = 0;
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (Character.isLetter(c)) letters++;
            else if (Character.isDigit(c)) digits++;
            else if (c == ' ') spaces++;
            else punct++;
        }
        System.out.println("Символов: " + s.length());
        System.out.println("Букв: " + letters);
        System.out.println("Цифр: " + digits);
        System.out.println("Пробелов: " + spaces);
        System.out.println("Знаков пунктуации: " + punct);
    }

    // 52. Шифр Цезаря
    static String task52(String s, int shift) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (c >= 'a' && c <= 'z') {
                sb.append((char) ((c - 'a' + shift) % 26 + 'a'));
            } else if (c >= 'A' && c <= 'Z') {
                sb.append((char) ((c - 'A' + shift) % 26 + 'A'));
            } else {
                sb.append(c);
            }
        }
        return sb.toString();
    }

    // 53. Дешифрование Цезаря
    static String task53(String s, int shift) {
        return task52(s, 26 - (shift % 26));
    }

    // 54. Замена запрещённых слов звёздочками
    static String task54(String s, String[] badWords) {
        String result = s;
        for (String bad : badWords) {
            StringBuilder stars = new StringBuilder();
            for (int i = 0; i < bad.length(); i++) stars.append('*');
            // Заменяем без учёта регистра вручную
            String lower = result.toLowerCase();
            String badLower = bad.toLowerCase();
            int idx = 0;
            StringBuilder sb = new StringBuilder(result);
            while ((idx = lower.indexOf(badLower, idx)) != -1) {
                sb.replace(idx, idx + bad.length(), stars.toString());
                lower = sb.toString().toLowerCase();
                idx += bad.length();
            }
            result = sb.toString();
        }
        return result;
    }

    // 55. Слова только в первом / только во втором
    static void task55(String a, String b) {
        Set<String> setA = new HashSet<>(Arrays.asList(task10(a).toLowerCase().split(" ")));
        Set<String> setB = new HashSet<>(Arrays.asList(task10(b).toLowerCase().split(" ")));
        Set<String> onlyA = new HashSet<>(setA);
        onlyA.removeAll(setB);
        Set<String> onlyB = new HashSet<>(setB);
        onlyB.removeAll(setA);
        System.out.println("Только в первом: " + onlyA);
        System.out.println("Только во втором: " + onlyB);
    }

    // 56. Баланс скобок
    static boolean task56(String s) {
        int balance = 0;
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (c == '(') balance++;
            else if (c == ')') {
                balance--;
                if (balance < 0) return false;
            }
        }
        return balance == 0;
    }

    // 57. Нормализация ФИО
    static String task57(String s) {
        return task10(s);
    }

    // 58. Все индексы вхождений фразы без учёта регистра
    static List<Integer> task58(String text, String phrase) {
        List<Integer> result = new ArrayList<>();
        String lowerText = text.toLowerCase();
        String lowerPhrase = phrase.toLowerCase();
        int idx = 0;
        while ((idx = lowerText.indexOf(lowerPhrase, idx)) != -1) {
            result.add(idx);
            idx++;
        }
        return result;
    }

    // 59. Первые 20 слов с многоточием
    static String task59(String text) {
        String[] words = task10(text).split(" ");
        if (words.length <= 20) return text;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 20; i++) {
            sb.append(words[i]);
            if (i < 19) sb.append(" ");
        }
        sb.append("...");
        return sb.toString();
    }

    // 60. Консольный «Текстовый помощник»
    static void task60() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Введите текст: ");
        String text = sc.nextLine();
        while (true) {
            System.out.println("\n--- Текстовый помощник ---");
            System.out.println("1. Подсчёт слов");
            System.out.println("2. Разворот строки");
            System.out.println("3. Поиск подстроки");
            System.out.println("4. Замена подстроки");
            System.out.println("5. Проверка палиндрома");
            System.out.println("0. Выход");
            System.out.print("Выбор: ");
            String choice = sc.nextLine();
            switch (choice) {
                case "1":
                    System.out.println("Слов: " + task21(text));
                    break;
                case "2":
                    System.out.println("Разворот: " + task11(text));
                    break;
                case "3":
                    System.out.print("Что искать: ");
                    String sub = sc.nextLine();
                    System.out.println("Индексы: " + task58(text, sub));
                    break;
                case "4":
                    System.out.print("Что заменить: ");
                    String from = sc.nextLine();
                    System.out.print("На что: ");
                    String to = sc.nextLine();
                    text = task36(text, from); // удаление, либо можно replace
                    text = text.replace(from, to);
                    System.out.println("Новый текст: " + text);
                    break;
                case "5":
                    System.out.println(task12(text) ? "Палиндром" : "Не палиндром");
                    break;
                case "0":
                    System.out.println("Выход.");
                    return;
                default:
                    System.out.println("Неверный выбор.");
            }
        }
    }

    // ==================== MAIN ====================
    public static void main(String[] args) {
        // Примеры вызова — можно раскомментировать нужное
        task1("Привет");
        task2("Привет Мир");
        task3("   текст   ");
        task4("HelloWorld", "Hello", "World");
        task5("banana", 'a', 'o');
        System.out.println("Вхождений 'a': " + task6("banana", 'a'));
        task7("abcabc", "bc");
        System.out.println(task8("Hello World", "WORLD"));
        System.out.println(task9("Java", "JAVA"));
        System.out.println(task10("  a   b   c  "));
        System.out.println(task11("hello"));
        System.out.println(task12("А роза упала на лапу Азора"));
        System.out.println(task13("abcdef", 3));
        System.out.println(task14("abcdef", 1, 4));
        System.out.println(task15("a b c"));
        System.out.println(task16("a1b2c3"));
        System.out.println(task17("a1b, c!"));
        System.out.println(task19("banana", 'a'));
        System.out.println(Arrays.toString(task20("abcdefg")));
        System.out.println(task21("  a  b   c "));
        System.out.println(task22("яблоко банан киви"));
        System.out.println(task23("яблоко банан киви"));
        System.out.println(task24("привет мир"));
        System.out.println(task25("apple banana apricot", 'a'));
        System.out.println(task26("Привет! Как дела? Хорошо."));
        System.out.println(task27("один два три"));
        System.out.println(task28("a b a c b a"));
        System.out.println(task29("a b c"));
        System.out.println(task30("Очень длинный текст", 10));
        System.out.println(task31("listen", "silent"));
        System.out.println(task32("префикс", "префиксный"));
        System.out.println(task33("abcdef", "cdefgh"));
        System.out.println(task34("aaaa", "aa"));
        System.out.println(task35("aaa", "a", "b"));
        System.out.println(task36("abcabc", "bc"));
        System.out.println(task37("2.10", "2.9"));
        System.out.println(Arrays.toString(task38(new String[]{"bob", "Alice", "charlie"})));
        System.out.println(task39("apple banana apricot", "ap"));
        System.out.println(task40("abc", "ac"));
        System.out.println(task41("test@example.com"));
        System.out.println(task42("+7 123 456-78-90"));
        System.out.println(task43("Passw0rd"));
        System.out.println(task44("Иван Иванов"));
        System.out.println(task45("1234567"));
        System.out.println(task46("12345"));
        System.out.println(task47("25-12-2024"));
        System.out.println(task48("  Иван   Иванов  "));
        System.out.println(task49("_myVar1"));
        System.out.println(task50("https://www.example.com/path"));
        task51("Hello, World! 123");
        System.out.println(task52("Hello, World!", 3));
        System.out.println(task53(task52("Hello, World!", 3), 3));
        System.out.println(task54("плохое слово тут", new String[]{"плохое"}));
        task55("a b c", "b c d");
        System.out.println(task56("(a(b)c)"));
        System.out.println(task57("  Иванов   Иван  Иванович "));
        System.out.println(task58("Abc abc ABC", "abc"));
        System.out.println(task59("word1 word2 word3 word4 word5 word6 word7 word8 word9 word10 word11 word12 word13 word14 word15 word16 word17 word18 word19 word20 word21"));

        // Раскомментируйте, чтобы запустить интерактивный помощник:
        // task60();
    }
}