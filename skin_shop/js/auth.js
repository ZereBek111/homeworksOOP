// Простая имитация авторизации через localStorage
// Позже заменим на реальный бэкенд

const Auth = {
  // Регистрация
  register(username, email, password) {
    const users = JSON.parse(localStorage.getItem('sv_users') || '[]');
    if (users.find(u => u.email === email)) {
      alert('Пользователь с таким email уже существует');
      return false;
    }
    const user = {
      id: Date.now(),
      username,
      email,
      password, // В реальном проекте хешируется!
      role: 'user',
      createdAt: new Date().toISOString()
    };
    users.push(user);
    localStorage.setItem('sv_users', JSON.stringify(users));
    localStorage.setItem('sv_current', JSON.stringify(user));
    return true;
  },

  // Вход
  login(email, password) {
    const users = JSON.parse(localStorage.getItem('sv_users') || '[]');
    const user = users.find(u => u.email === email && u.password === password);
    if (!user) return false;
    localStorage.setItem('sv_current', JSON.stringify(user));
    return true;
  },

  // Выход
  logout() {
    localStorage.removeItem('sv_current');
    window.location.href = 'index.html';
  },

  // Текущий юзер
  current() {
    return JSON.parse(localStorage.getItem('sv_current') || 'null');
  }
};

// ============ ОБРАБОТКА ФОРМ ============
document.addEventListener('DOMContentLoaded', () => {
  // Регистрация
  const regForm = document.getElementById('registerForm');
  if (regForm) {
    regForm.addEventListener('submit', e => {
      e.preventDefault();
      const fd = new FormData(regForm);
      if (Auth.register(fd.get('username'), fd.get('email'), fd.get('password'))) {
        alert('Аккаунт создан! Добро пожаловать 🎉');
        window.location.href = 'dashboard.html';
      }
    });
  }

  // Вход
  const loginForm = document.getElementById('loginForm');
  if (loginForm) {
    loginForm.addEventListener('submit', e => {
      e.preventDefault();
      const fd = new FormData(loginForm);
      if (Auth.login(fd.get('email'), fd.get('password'))) {
        window.location.href = 'dashboard.html';
      } else {
        alert('Неверный email или пароль');
      }
    });
  }

  // Выход
  const logoutBtn = document.getElementById('logoutBtn');
  if (logoutBtn) logoutBtn.addEventListener('click', () => Auth.logout());

  // Показать юзера в навбаре
  const userChip = document.getElementById('userChip');
  const navAuth = document.getElementById('navAuth');
  const current = Auth.current();
  if (current && userChip) {
    userChip.textContent = '👤 ' + current.username;
  }
  if (current && navAuth) {
    navAuth.innerHTML = `
      <a href="dashboard.html" class="btn btn-ghost">Кабинет</a>
      <button class="btn btn-outline" onclick="Auth.logout()">Выйти</button>
    `;
  }
});

window.Auth = Auth;