document.addEventListener('DOMContentLoaded', () => {
  const tabs = document.querySelectorAll('.dash-tab');
  const panes = document.querySelectorAll('.dash-pane');

  tabs.forEach(tab => {
    tab.addEventListener('click', (e) => {
      e.preventDefault();
      tabs.forEach(t => t.classList.remove('active'));
      panes.forEach(p => p.classList.remove('active'));
      tab.classList.add('active');
      const pane = document.getElementById(tab.dataset.tab);
      if (pane) pane.classList.add('active');
    });
  });

  // Заполнить настройки текущим юзером
  const current = window.Auth ? Auth.current() : null;
  if (current) {
    const u = document.getElementById('setUsername');
    const em = document.getElementById('setEmail');
    if (u) u.value = current.username || '';
    if (em) em.value = current.email || '';
  }
});