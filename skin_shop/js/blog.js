document.addEventListener('DOMContentLoaded', () => {
  const createBtn = document.getElementById('createPostBtn');
  const form = document.getElementById('postForm');
  const cancelBtn = document.getElementById('cancelPost');
  const submitBtn = document.getElementById('submitPost');
  const grid = document.getElementById('blogGrid');

  // Показать форму
  createBtn.addEventListener('click', () => {
    form.classList.remove('hidden');
    form.scrollIntoView({ behavior: 'smooth' });
  });

  // Скрыть форму
  cancelBtn.addEventListener('click', () => {
    form.classList.add('hidden');
  });

  // Загрузить сохранённые посты
  const saved = JSON.parse(localStorage.getItem('rv_posts') || '[]');
  saved.forEach(p => renderPost(p));

  // Создать пост
  submitBtn.addEventListener('click', () => {
    const title = document.getElementById('postTitle').value.trim();
    const text = document.getElementById('postText').value.trim();
    const tag = document.getElementById('postTag').value;
    const fileInput = document.getElementById('postImage');

    if (!title || !text) {
      alert('Заполни заголовок и текст поста');
      return;
    }

    const reader = new FileReader();
    const finish = (imageData) => {
      const post = {
        id: Date.now(),
        title, text, tag,
        image: imageData || null,
        author: (window.Auth && Auth.current()) ? Auth.current().username : 'Гость',
        date: new Date().toLocaleDateString('ru-RU')
      };
      saved.push(post);
      localStorage.setItem('rv_posts', JSON.stringify(saved));
      renderPost(post);

      // очистка
      document.getElementById('postTitle').value = '';
      document.getElementById('postText').value = '';
      fileInput.value = '';
      form.classList.add('hidden');
    };

    if (fileInput.files[0]) {
      const r = new FileReader();
      r.onload = e => finish(e.target.result);
      r.readAsDataURL(fileInput.files[0]);
    } else {
      finish(null);
    }
  });

  function renderPost(post) {
    const article = document.createElement('article');
    article.className = 'blog-card';
    article.innerHTML = `
      <div class="blog-cover" ${post.image ? `style="background-image:url('${post.image}')"` : 'style="background:linear-gradient(135deg,#7c3aed,#06b6d4)"'}></div>
      <div class="blog-body">
        <span class="tag ${post.tag}">${post.tag === 'epic' ? 'ОБЗОР' : post.tag === 'rare' ? 'ГАЙД' : 'НОВОСТИ'}</span>
        <h3>${escapeHtml(post.title)}</h3>
        <p class="muted">${escapeHtml(post.text).slice(0, 100)}...</p>
        <div class="blog-meta">
          <span>👤 ${escapeHtml(post.author)}</span>
          <span>📅 ${post.date}</span>
        </div>
      </div>
    `;
    grid.prepend(article);
  }

  function escapeHtml(str) {
    return String(str).replace(/[&<>"']/g, m => ({
      '&':'&amp;','<':'&lt;','>':'&gt;','"':'&quot;',"'":'&#39;'
    }[m]));
  }
});