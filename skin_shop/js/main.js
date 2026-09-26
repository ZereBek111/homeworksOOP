document.addEventListener('DOMContentLoaded', () => {

  // ============ ФИЛЬТРЫ СКИНОВ ============
  const filterButtons = document.querySelectorAll('#skinFilters .chip');
  const skinCards = document.querySelectorAll('#skinGrid .skin-card');

  filterButtons.forEach(btn => {
    btn.addEventListener('click', () => {
      // активный чип
      filterButtons.forEach(b => b.classList.remove('active'));
      btn.classList.add('active');

      const filter = btn.dataset.filter;

      skinCards.forEach(card => {
        const rarity = card.dataset.rarity;
        if (filter === 'all' || rarity === filter) {
          card.style.display = '';
          card.style.animation = 'fadeIn 0.3s ease';
        } else {
          card.style.display = 'none';
        }
      });

      // Если фильтр не "все" — скрываем кнопку "ещё скины"
      const moreBtn = document.getElementById('moreSkinsBtn');
      const moreSkins = document.getElementById('moreSkins');
      if (moreBtn && moreSkins) {
        if (filter !== 'all') {
          moreBtn.style.display = 'none';
          moreSkins.classList.add('hidden');
        } else {
          moreBtn.style.display = '';
        }
      }
    });
  });

  // ============ ЕЩЁ СКИНЫ ============
  const moreBtn = document.getElementById('moreSkinsBtn');
  const moreSkins = document.getElementById('moreSkins');
  if (moreBtn && moreSkins) {
    moreBtn.addEventListener('click', () => {
      moreSkins.classList.toggle('hidden');
      moreBtn.textContent = moreSkins.classList.contains('hidden')
        ? 'Ещё скины ↓'
        : 'Скрыть ↑';
    });
  }
});

// анимация появления
const style = document.createElement('style');
style.textContent = `@keyframes fadeIn { from { opacity:0; transform:translateY(10px);} to {opacity:1; transform:translateY(0);} }`;
document.head.appendChild(style);