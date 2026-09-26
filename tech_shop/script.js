const db = [
            {
                id: 1, name: "Yale Linus Smart Lock", category: "smart", price: 120000, oldPrice: 142000,
                image: "https://gw-assets.assaabloy.com/is/image/assaabloy/5052847131336.MAIN-6",
                badge: "-15%",
                desc: "Yale Linus® Smart Lock — это умный замок, который позволяет закрывать и открывать дверь без ключа. Он устанавливается поверх существующего цилиндра с внутренней стороны двери, поэтому снаружи ваша дверь выглядит так же, как и раньше. Управляйте доступом со смартфона, выдавайте виртуальные ключи гостям и просматривайте историю входов.",
                specs: { "Тип устройства": "Умный дверной замок", "Совместимость": "Apple HomeKit, Google Home", "Протокол": "Bluetooth 4.2, Wi-Fi", "Питание": "4 батарейки AA", "Материал": "Металл", "Цвет": "Серебристый" }
            },
            {
                id: 2, name: "Roborock S7 MaxV Ultra", category: "cleaning", price: 450000, oldPrice: null,
                image: "https://resources.cdn-kaspi.kz/img/m/p/hb7/hc1/65052476243998.jpg?format=gallery-medium",
                badge: "HIT",
                desc: "Флагманский робот-пылесос с самой продвинутой док-станцией Empty Wash Fill Dock. Он не только пылесосит и моет пол (виброшвабра), но и сам очищает пылесборник, стирает тряпку и наполняет бак водой. Встроенная камера с ИИ и 3D-сканированием распознает провода, носки и экскременты животных, объезжая их даже в полной темноте.",
                specs: { "Мощность": "5100 Па", "Навигация": "LiDAR + RGB + 3D", "Влажная уборка": "Sonic Mopping", "Станция": "Самоочистка (мусор/вода/тряпка)", "Аккумулятор": "5200 мАч", "Шум": "67 дБ" }
            },
            {
                id: 3, name: "Dyson Purifier Cool™ TP07", category: "smart", price: 320000, oldPrice: null,
                image: "https://dyson-h.assetsadobe2.com/is/image/content/dam/dyson/images/products/hero/385278-01.png?$responsive$&cropPathE=mobile&fit=stretch,1&wid=640",
                badge: null,
                desc: "Интеллектуальный очиститель воздуха с функцией вентилятора. Улавливает 99.95% мельчайших частиц, включая аллергены и вирусы H1N1. Полностью герметичен по стандарту HEPA H13. Автоматически распознает и удаляет загрязнители, отображая информацию на LCD-экране в реальном времени. Работает тихо в ночном режиме.",
                specs: { "Фильтр": "HEPA H13 + Угольный", "Площадь": "до 40 м²", "Управление": "Пульт, Dyson Link App", "Функции": "Очистка, Охлаждение", "Вращение": "350°", "Вес": "4.65 кг" }
            },
            {
                id: 4, name: "Smeg Espresso Machine", category: "kitchen", price: 180000, oldPrice: null,
                image: "https://cdn.entero.ru/mp@2x/77/e2/77e2bbce525230cd6cc4ffa1137f0dde.jpg",
                badge: "Design",
                desc: "Эспрессо-кофемашина в стиле 50-х годов. Идеальное сочетание итальянского дизайна и современных технологий. Приготовьте настоящий эспрессо или капучино с густой пенкой благодаря профессиональному давлению 15 бар. Термоблок обеспечивает быстрый нагрев воды до идеальной температуры.",
                specs: { "Давление": "15 Бар", "Тип": "Рожковая", "Капучинатор": "Ручной (паровая трубка)", "Корпус": "Нержавеющая сталь", "Объем бака": "1 л", "Страна": "Италия" }
            },
            {
                id: 5, name: "Samsung Bespoke Fridge", category: "kitchen", price: 850000, oldPrice: 940000,
                image: "https://image-us.samsung.com/SamsungUS/home/home-appliances/refrigerators/bespoke/rf23bb8600qlaa/RF23BB8600QL_01_Stainless_Steel_SCOM.jpg?$product-details-jpg$?$product-details-jpg$",
                badge: "SALE",
                desc: "Холодильник, который подстраивается под вас. Система Bespoke позволяет менять цвета и фактуру внешних панелей, чтобы идеально вписать технику в интерьер вашей кухни. Технология Metal Cooling сохраняет свежесть продуктов дольше, удерживая холод внутри даже при частом открывании дверцы.",
                specs: { "Объем": "350 л", "Система": "Full No Frost", "Особенность": "Сменные панели", "Компрессор": "Инверторный", "Шум": "35 дБ (Тихий)", "Класс": "A+" }
            },
            {
                id: 6, name: "Sonos One Gen 2", category: "smart", price: 110000, oldPrice: null,
                image: "https://m.media-amazon.com/images/I/71dJ0HXTD0L._AC_SL1500_.jpg",
                badge: null,
                desc: "Компактная умная колонка с мощным звуком, заполняющим комнату. Идеально подходит для кухни или ванной благодаря влагозащите. Поддерживает Apple AirPlay 2 и голосовое управление. Можно объединить две колонки в стереопару или подключить к саундбару Sonos для домашнего кинотеатра.",
                specs: { "Подключение": "Wi-Fi, Ethernet, AirPlay 2", "Влагозащита": "Есть (устойчив к пару)", "Микрофоны": "Дальнего поля", "Аудио": "2 цифровых усилителя", "Габариты": "161x119 мм" }
            }
        ];

        const initialReviews = [
            { name: "Азамат К.", rating: "★★★★★", text: "Замок Yale - топ. Работает с HomeKit.", product: "Yale Linus Smart Lock", photo: "" },
            { name: "Елена С.", rating: "★★★★★", text: "Робот спасение от шерсти. Карта точная.", product: "Roborock S7 MaxV Ultra", photo: "https://images.unsplash.com/photo-1518791841217-8f162f1e1131?q=80&w=200&auto=format&fit=crop" },
            { name: "Дмитрий В.", rating: "★★☆☆☆", text: "Доставка опоздала на 2 дня. Упаковка была помята, но холодильник цел.", product: "Samsung Bespoke Fridge", photo: "" },
            { name: "Алина М.", rating: "★★★★★", text: "Smeg - украшение кухни. Кофе варит вкусный.", product: "Smeg Espresso Machine", photo: "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?q=80&w=200&auto=format&fit=crop" }
        ];

        const PRODUCT_IMAGE_PLACEHOLDER = "https://placehold.co/600x400/ffffff/34145c?text=No+Photo";

        // ============ ПОЛЬЗОВАТЕЛИ (НОВОЕ) ============
        const usersDB = {
            _data: null,
            currentUser: null,

            init() {
                this._data = JSON.parse(localStorage.getItem('ds_users')) || {};
                this.currentUser = JSON.parse(sessionStorage.getItem('ds_current_user')) || null;
            },

            save() {
                localStorage.setItem('ds_users', JSON.stringify(this._data));
            },

            register(email, password, name) {
                if (this._data[email]) return { success: false, error: 'Пользователь с таким email уже существует' };
                this._data[email] = {
                    password,
                    name,
                    email,
                    favorites: [],
                    orders: [],
                    createdAt: new Date().toISOString()
                };
                this.save();
                return { success: true };
            },

            login(email, password) {
                const user = this._data[email];
                if (!user) return { success: false, error: 'Пользователь не найден' };
                if (user.password !== password) return { success: false, error: 'Неверный пароль' };
                this.currentUser = { ...user, email };
                sessionStorage.setItem('ds_current_user', JSON.stringify(this.currentUser));
                return { success: true };
            },

            logout() {
                this.currentUser = null;
                sessionStorage.removeItem('ds_current_user');
            },

            getCurrentUser() {
                return this.currentUser;
            },

            addFavorite(productId) {
                if (!this.currentUser) return;
                const user = this._data[this.currentUser.email];
                if (!user.favorites.includes(productId)) {
                    user.favorites.push(productId);
                    this.save();
                    this.currentUser = { ...user, email: this.currentUser.email };
                    sessionStorage.setItem('ds_current_user', JSON.stringify(this.currentUser));
                }
            },

            removeFavorite(productId) {
                if (!this.currentUser) return;
                const user = this._data[this.currentUser.email];
                user.favorites = user.favorites.filter(id => id !== productId);
                this.save();
                this.currentUser = { ...user, email: this.currentUser.email };
                sessionStorage.setItem('ds_current_user', JSON.stringify(this.currentUser));
            },

            isFavorite(productId) {
                if (!this.currentUser) return false;
                const user = this._data[this.currentUser.email];
                return user.favorites.includes(productId);
            },

            addOrder(order) {
                if (!this.currentUser) return;
                const user = this._data[this.currentUser.email];
                user.orders.push({ ...order, orderId: Date.now(), date: new Date().toISOString() });
                this.save();
                this.currentUser = { ...user, email: this.currentUser.email };
                sessionStorage.setItem('ds_current_user', JSON.stringify(this.currentUser));
            }
        };

        const app = {
            cart: [],
            isVip: false,
            currentPaymentMethod: 'Карта',
            currentFilter: 'all',
            searchQuery: '',

            init: function () {
                usersDB.init();
                this.loadDb();
                this.renderProducts('all');
                this.renderReviews();
                this.populateProductSelect();
                this.updateCartUI();
                this.updateAuthUI();
                this.bindEvents();
            },

            escapeHTML: function (value) {
                return String(value ?? '')
                    .replaceAll('&', '&amp;')
                    .replaceAll('<', '&lt;')
                    .replaceAll('>', '&gt;')
                    .replaceAll('"', '&quot;')
                    .replaceAll("'", '&#039;');
            },

            getProductImage: function (product) {
                return product && product.image ? product.image : PRODUCT_IMAGE_PLACEHOLDER;
            },

            getProductById: function (id) {
                return db.find(x => String(x.id) === String(id));
            },

            getCategoryTitle: function (cat) {
                const names = { smart: 'Smart Home', kitchen: 'Кухня', cleaning: 'Уборка' };
                return names[cat] || cat || 'Другое';
            },

            specsToText: function (specs) {
                return Object.entries(specs || {}).map(([key, value]) => `${key}: ${value}`).join('\n');
            },

            specsFromText: function (text) {
                const specs = {};
                String(text || '').split('\n').forEach(line => {
                    const separatorIndex = line.indexOf(':');
                    if (separatorIndex === -1) return;
                    const key = line.slice(0, separatorIndex).trim();
                    const value = line.slice(separatorIndex + 1).trim();
                    if (key && value) specs[key] = value;
                });
                return specs;
            },

            refreshCatalog: function () {
                this.renderProducts(this.currentFilter || 'all');
                this.populateProductSelect();
                this.updateCartUI();
            },

            // ===== ПОИСК (НОВОЕ) =====
            searchProducts: function (query) {
                this.searchQuery = query.toLowerCase().trim();
                document.querySelectorAll('.filter-btn').forEach(b => b.classList.remove('active'));
                const allBtn = document.querySelector('.filter-btn[data-filter="all"]');
                if (allBtn) allBtn.classList.add('active');
                this.currentFilter = 'all';
                this.renderProducts('all');
            },

            renderProducts: function (cat) {
                this.currentFilter = cat || this.currentFilter || 'all';
                let products = db.filter(p => this.currentFilter === 'all' || p.category === this.currentFilter);

                if (this.searchQuery) {
                    products = products.filter(p =>
                        p.name.toLowerCase().includes(this.searchQuery) ||
                        (p.desc || '').toLowerCase().includes(this.searchQuery) ||
                        p.category.includes(this.searchQuery)
                    );
                }

                const container = document.getElementById('productsContainer');
                const currentUser = usersDB.getCurrentUser();

                container.innerHTML = products.length ? products.map(p => {
                    const safeName = this.escapeHTML(p.name);
                    const safeCategory = this.escapeHTML(this.getCategoryTitle(p.category));
                    const safeImage = this.escapeHTML(this.getProductImage(p));
                    const safeBadge = this.escapeHTML(p.badge || '');
                    const price = Number(p.price || 0);
                    const oldPrice = p.oldPrice ? Number(p.oldPrice) : null;
                    const priceHtml = oldPrice
                        ? `<div class="product-price-block"><span class="price-old">${oldPrice.toLocaleString()} ₸</span><span class="price-current">${price.toLocaleString()} ₸</span></div>`
                        : `<div class="product-price-block"><span class="price-current">${price.toLocaleString()} ₸</span></div>`;

                    const isFav = currentUser && usersDB.isFavorite(p.id);
                    const favBtn = currentUser ? `
                        <button class="fav-btn ${isFav ? 'active' : ''}" onclick="event.stopPropagation(); app.toggleFavorite(${p.id})">
                            ${isFav ? '❤️' : '🤍'}
                        </button>
                    ` : '';

                    let displayName = safeName;
                    if (this.searchQuery) {
                        const regex = new RegExp(`(${this.searchQuery})`, 'gi');
                        displayName = safeName.replace(regex, '<mark style="background: var(--accent-glow); color: white; padding: 0 4px; border-radius: 3px;">$1</mark>');
                    }

                    return `
                        <div class="product-card" onclick="app.openProductModal(${p.id})">
                            ${p.badge ? `<div class="sale-badge">${safeBadge}</div>` : ''}
                            ${favBtn}
                            <div class="catalog-admin-actions" onclick="event.stopPropagation()">
                                <button class="admin-btn edit" onclick="app.openEditProductModal(${p.id})">Изменить</button>
                                <button class="admin-btn delete" onclick="app.deleteProduct(${p.id})">Удалить</button>
                            </div>
                            <div class="product-image-wrapper"><img src="${safeImage}" alt="${safeName}" onerror="this.src='${PRODUCT_IMAGE_PLACEHOLDER}'"></div>
                            <div class="product-info">
                                <span class="product-cat">${safeCategory}</span>
                                <div class="product-title">${displayName}</div>
                                ${priceHtml}
                                <div class="card-buttons">
                                    <div class="btn-details" onclick="event.stopPropagation(); app.openProductModal(${p.id})">Детали</div>
                                    <button class="btn" onclick="event.stopPropagation(); app.addToCart(${p.id})">В корзину</button>
                                </div>
                            </div>
                        </div>`;
                }).join('') : `<div class="empty-catalog">${this.searchQuery ? `По запросу «${this.escapeHTML(this.searchQuery)}» ничего не найдено` : 'В этой категории пока нет товаров.'}</div>`;
            },

            filterProducts: function (cat, btn) {
                this.searchQuery = '';
                const searchInput = document.getElementById('searchInput');
                if (searchInput) searchInput.value = '';
                document.querySelectorAll('.filter-btn').forEach(b => b.classList.remove('active'));
                btn.classList.add('active');
                this.renderProducts(cat);
            },

            openProductModal: function (id) {
                const p = this.getProductById(id);
                if (!p) return this.showToast('Товар не найден');

                let specs = '';
                for (let k in (p.specs || {})) {
                    specs += `<tr><td class="specs-key">${this.escapeHTML(k)}</td><td class="specs-val">${this.escapeHTML(p.specs[k])}</td></tr>`;
                }
                if (!specs) specs = '<tr><td class="specs-key">Характеристики</td><td class="specs-val">Не указаны</td></tr>';

                const price = Number(p.price || 0);
                let priceDisplay = `<div class="pd-price-lg">${price.toLocaleString()} ₸</div>`;
                if (p.oldPrice) {
                    priceDisplay = `<div style="display:flex;gap:15px;align-items:baseline;margin-bottom:20px;"><div style="text-decoration:line-through;color:var(--text-muted);font-size:20px;">${Number(p.oldPrice).toLocaleString()} ₸</div><div class="pd-price-lg">${price.toLocaleString()} ₸</div></div>`;
                }

                const currentUser = usersDB.getCurrentUser();
                const isFav = currentUser && usersDB.isFavorite(p.id);
                const favBtn = currentUser ? `
                    <button class="btn-outline" onclick="app.toggleFavorite(${p.id}); app.openProductModal(${p.id})" style="margin-right:10px;">
                        ${isFav ? '❤️ В избранном' : '🤍 В избранное'}
                    </button>
                ` : '';

                document.getElementById('productModalBody').innerHTML = `
                    <div class="pd-grid">
                        <div class="pd-image-col"><img src="${this.escapeHTML(this.getProductImage(p))}" alt="${this.escapeHTML(p.name)}" onerror="this.src='${PRODUCT_IMAGE_PLACEHOLDER}'"></div>
                        <div class="pd-info-col">
                            <div class="pd-header"><div class="pd-title-lg">${this.escapeHTML(p.name)}</div>${priceDisplay}</div>
                            <div class="pd-description">${this.escapeHTML(p.desc || '')}</div>
                            <h4 style="margin-bottom:15px; color:white;">Характеристики</h4>
                            <table class="specs-table">${specs}</table>
                            <div class="pd-actions">
                                <button class="btn" onclick="app.addToCart(${p.id}); app.closeModal('productModal')">Добавить в корзину</button>
                                ${favBtn}
                                <button class="btn-outline" onclick="app.openEditProductModal(${p.id}); app.closeModal('productModal')">Изменить</button>
                                <button class="btn-danger" onclick="app.deleteProduct(${p.id})">Удалить</button>
                            </div>
                        </div>
                    </div>
                `;
                document.getElementById('productModal').classList.add('active');
            },

            closeModal: function (id) {
                const modal = document.getElementById(id);
                if (modal) modal.classList.remove('active');
            },

            // ===== ИЗБРАННОЕ (НОВОЕ) =====
            toggleFavorite: function (productId) {
                if (!usersDB.getCurrentUser()) {
                    this.showToast('Войдите в аккаунт, чтобы добавлять в избранное');
                    document.getElementById('authModal').classList.add('active');
                    return;
                }
                if (usersDB.isFavorite(productId)) {
                    usersDB.removeFavorite(productId);
                    this.showToast('Удалено из избранного');
                } else {
                    usersDB.addFavorite(productId);
                    this.showToast('Добавлено в избранное ❤️');
                }
                this.renderProducts(this.currentFilter);
            },

            addToCart: function (id) {
                const p = this.getProductById(id);
                if (!p) return this.showToast('Товар не найден');
                this.cart.push({ ...p, tId: Date.now() + Math.random() });
                this.updateCartUI();
                this.showToast('✅ Добавлено');
            },

            removeFromCart: function (tId) {
                this.cart = this.cart.filter(x => String(x.tId) !== String(tId));
                this.updateCartUI();
            },

            updateCartUI: function () {
                document.getElementById('headerCartCount').innerText = this.cart.length;
                let html = this.cart.length ? this.cart.map(i => `<div class="cart-item"><div><div>${this.escapeHTML(i.name)}</div><div style="font-size:12px; color:#aaa;">${Number(i.price || 0).toLocaleString()} ₸</div></div><button onclick="app.removeFromCart('${i.tId}')" style="background:none; color:#555; font-size:18px;">✕</button></div>`).join('') : '<p style="text-align:center;color:#555">Пусто</p>';
                document.getElementById('cartItemsList').innerHTML = html;
                let total = this.cart.reduce((a, b) => a + Number(b.price || 0), 0);
                if (this.isVip) {
                    total *= 0.8;
                    document.getElementById('cartVipLine').style.display = 'flex';
                    document.getElementById('cartDiscount').innerText = '-20%';
                } else {
                    document.getElementById('cartVipLine').style.display = 'none';
                }
                document.getElementById('cartTotal').innerText = total.toLocaleString() + ' ₸';
                document.querySelectorAll('.final-price').forEach(e => e.innerText = total.toLocaleString() + ' ₸');
            },

            toggleCart: function () {
                document.getElementById('cartModal').classList.toggle('active');
            },

            openCheckout: function () {
                if (!this.cart.length) return this.showToast('Пусто');
                if (!usersDB.getCurrentUser()) {
                    this.showToast('Войдите в аккаунт для оформления заказа');
                    document.getElementById('authModal').classList.add('active');
                    return;
                }
                this.toggleCart();
                document.getElementById('checkoutModal').classList.add('active');
                document.getElementById('stepContacts').classList.add('active');
                document.getElementById('stepPayment').classList.remove('active');
                document.getElementById('stepSuccess').classList.remove('active');
            },

            goToPayment: function () {
                document.getElementById('stepContacts').classList.remove('active');
                document.getElementById('stepPayment').classList.add('active');
            },

            backToContacts: function () {
                document.getElementById('stepPayment').classList.remove('active');
                document.getElementById('stepContacts').classList.add('active');
            },

            selectPayment: function (type, btn) {
                this.currentPaymentMethod = type === 'card' ? 'Банковская карта' : (type === 'kaspi' ? 'Kaspi QR' : 'Halyk QR');
                document.querySelectorAll('.pay-opt').forEach(b => b.classList.remove('active'));
                btn.classList.add('active');
                document.getElementById('payContentCard').style.display = type === 'card' ? 'block' : 'none';
                document.getElementById('payContentQR').style.display = type !== 'card' ? 'block' : 'none';
                if (type !== 'card') {
                    document.getElementById('qrTitle').innerText = type === 'kaspi' ? 'Kaspi QR' : 'Halyk QR';
                    document.getElementById('qrImage').src = `https://api.qrserver.com/v1/create-qr-code/?size=200x200&data=DS-${type.toUpperCase()}-PAY`;
                    setTimeout(() => { if (document.getElementById('checkoutModal').classList.contains('active')) this.finishPayment(); }, 4000);
                }
            },

            processPayment: function (btn) {
                btn.innerText = 'Обработка...';
                setTimeout(() => { this.finishPayment(); btn.innerText = 'Оплатить'; }, 2000);
            },

            finishPayment: function () {
                const date = new Date().toLocaleString('ru-RU');
                const orderId = Math.floor(Math.random() * 1000000000);
                const name = document.getElementById('clientName').value.trim() || 'Гость';
                const phone = document.getElementById('clientPhone').value.trim() || 'Не указан';

                let rawTotal = this.cart.reduce((a, b) => a + Number(b.price || 0), 0);
                let discount = this.isVip ? rawTotal * 0.2 : 0;
                let finalTotal = rawTotal - discount;

                let itemsHtml = '';
                this.cart.forEach(i => { itemsHtml += `<div class="receipt-row"><span>${this.escapeHTML(i.name)}</span><span>${Number(i.price || 0).toLocaleString()}</span></div>`; });

                let pricingHtml = this.isVip
                    ? `<div class="receipt-row"><span>Подытог:</span><span>${rawTotal.toLocaleString()}</span></div><div class="receipt-row"><span>Скидка VIP:</span><span>-${discount.toLocaleString()}</span></div><div class="receipt-line"></div><div class="receipt-row receipt-bold"><span>ИТОГО:</span><span>${finalTotal.toLocaleString()} ₸</span></div>`
                    : `<div class="receipt-row receipt-bold"><span>ИТОГО:</span><span>${finalTotal.toLocaleString()} ₸</span></div>`;

                document.getElementById('receiptPlace').innerHTML = `
                    <div class="receipt-container">
                        <div class="receipt-header"><h2>DoubleSmart LLP</h2><p>БИН 240540008899</p><p>г. Астана, ул. Туран 42</p><p class="receipt-bold">ЧЕК ПРОДАЖИ №${orderId}</p></div>
                        <div class="receipt-line"></div>${itemsHtml}<div class="receipt-line"></div>${pricingHtml}<div class="receipt-line"></div>
                        <div class="receipt-row"><span>Клиент:</span><span>${this.escapeHTML(name)}</span></div>
                        <div class="receipt-row"><span>Телефон:</span><span>${this.escapeHTML(phone)}</span></div>
                        <div class="receipt-row"><span>Оплата:</span><span>${this.currentPaymentMethod}</span></div>
                        <div class="receipt-row"><span>Дата:</span><span>${date}</span></div>
                        <div class="receipt-footer"><p>ФИСКАЛЬНЫЙ ЧЕК</p><img src="https://api.qrserver.com/v1/create-qr-code/?size=100x100&data=CHECK-${orderId}" class="receipt-qr"><p>Спасибо за покупку!</p></div>
                    </div>
                `;

                const orderData = {
                    items: [...this.cart],
                    total: finalTotal,
                    rawTotal,
                    discount,
                    name,
                    phone,
                    paymentMethod: this.currentPaymentMethod,
                    isVip: this.isVip
                };
                usersDB.addOrder(orderData);

                this.cart = [];
                this.updateCartUI();
                document.getElementById('stepPayment').classList.remove('active');
                document.getElementById('stepSuccess').classList.add('active');
            },

            checkLoyalty: function () {
                if (document.getElementById('contractInput').value.toUpperCase().startsWith('DS')) {
                    this.isVip = true;
                    document.getElementById('loyaltySuccess').style.display = 'block';
                    this.updateCartUI();
                    this.showToast('✅ VIP-статус активирован!');
                } else {
                    this.showToast('❌ Неверный номер договора');
                }
            },

            renderReviews: function () {
                document.getElementById('reviewsList').innerHTML = initialReviews.map(r => this.createReviewHTML(r)).join('');
            },

            createReviewHTML: function (r) {
                const imgHTML = r.photo ? `<img src="${this.escapeHTML(r.photo)}" class="review-img-preview" onclick="window.open('${this.escapeHTML(r.photo)}')">` : '';
                return `<div class="review-card"><div style="display:flex;justify-content:space-between;margin-bottom:8px;"><div class="stars">${this.escapeHTML(r.rating)}</div><span style="font-size:10px;color:var(--accent-glow);background:rgba(123,44,191,0.2);padding:2px 8px;border-radius:4px;">${this.escapeHTML(r.product)}</span></div><p style="font-size:14px;color:#ccc;">"${this.escapeHTML(r.text)}"</p>${imgHTML}<div class="user" style="display:flex;gap:10px;align-items:center;margin-top:15px;"><div style="width:32px;height:32px;background:#333;border-radius:50%;display:flex;align-items:center;justify-content:center;font-weight:700;">${this.escapeHTML(r.name[0] || '?')}</div><div style="font-size:13px;font-weight:600;">${this.escapeHTML(r.name)}</div></div></div>`;
            },

            populateProductSelect: function () {
                const select = document.getElementById('revProduct');
                if (!select) return;
                select.innerHTML = '<option disabled selected value="">Выберите купленный товар</option>';
                db.forEach(p => {
                    const o = document.createElement('option');
                    o.value = p.name;
                    o.innerText = p.name;
                    select.appendChild(o);
                });
            },

            handleFileSelect: function (input) {
                if (input.files[0]) document.getElementById('fileName').innerText = input.files[0].name;
            },

            submitReview: function (e) {
                e.preventDefault();
                const name = document.getElementById('revName').value;
                const prod = document.getElementById('revProduct').value;
                const text = document.getElementById('revText').value;
                const rating = document.getElementById('revRating').value;
                const file = document.getElementById('revPhoto').files[0];
                initialReviews.unshift({ name, product: prod, rating, text, photo: file ? URL.createObjectURL(file) : "" });
                this.renderReviews();
                e.target.reset();
                this.showToast('Отзыв добавлен');
            },

            openAddProductModal: function () {
                document.getElementById('addProductModal').classList.add('active');
            },

            submitNewProduct: function (e) {
                e.preventDefault();
                const name = document.getElementById('newProdName').value.trim();
                const cat = document.getElementById('newProdCat').value;
                const price = parseInt(document.getElementById('newProdPrice').value, 10);
                const image = document.getElementById('newProdImage').value.trim();
                const desc = document.getElementById('newProdDesc').value.trim();
                const specs = this.specsFromText(document.getElementById('newProdSpecs').value);

                if (!name || !cat || !price || !image) return this.showToast('Заполните название, категорию, цену и фото');

                db.push({
                    id: Date.now(),
                    name,
                    category: cat,
                    price,
                    oldPrice: null,
                    image,
                    badge: 'NEW',
                    desc,
                    specs
                });

                this.saveDb();
                this.currentFilter = 'all';
                document.querySelectorAll('.filter-btn').forEach(b => b.classList.remove('active'));
                document.querySelector('.filter-btn')?.classList.add('active');
                this.refreshCatalog();
                this.closeModal('addProductModal');
                e.target.reset();
                this.showToast('Товар добавлен');
            },

            openEditProductModal: function (id) {
                const p = this.getProductById(id);
                if (!p) return this.showToast('Товар не найден');
                this.closeModal('productModal');

                document.getElementById('editProdId').value = p.id;
                document.getElementById('editProdName').value = p.name || '';
                document.getElementById('editProdCat').value = p.category || 'smart';
                document.getElementById('editProdPrice').value = p.price || '';
                document.getElementById('editProdImage').value = p.image || '';
                document.getElementById('editProdDesc').value = p.desc || '';
                document.getElementById('editProdSpecs').value = this.specsToText(p.specs || {});
                document.getElementById('editPhotoName').innerText = 'Можно вставить URL или выбрать файл';
                document.getElementById('editProdPhotoFile').value = '';
                document.getElementById('editPhotoPreview').src = this.getProductImage(p);
                document.getElementById('editProductModal').classList.add('active');
            },

            previewEditProductPhoto: function (input) {
                const file = input.files && input.files[0];
                if (!file) return;
                const reader = new FileReader();
                reader.onload = () => {
                    document.getElementById('editPhotoPreview').src = reader.result;
                    document.getElementById('editPhotoName').innerText = file.name;
                };
                reader.readAsDataURL(file);
            },

            getSelectedEditPhoto: function () {
                const fileInput = document.getElementById('editProdPhotoFile');
                const file = fileInput.files && fileInput.files[0];
                if (!file) return Promise.resolve(document.getElementById('editProdImage').value.trim());

                return new Promise((resolve, reject) => {
                    const reader = new FileReader();
                    reader.onload = () => resolve(reader.result);
                    reader.onerror = () => reject(new Error('Не удалось прочитать фото'));
                    reader.readAsDataURL(file);
                });
            },

            submitEditProduct: async function (e) {
                e.preventDefault();
                const id = document.getElementById('editProdId').value;
                const p = this.getProductById(id);
                if (!p) return this.showToast('Товар не найден');

                const newPrice = parseInt(document.getElementById('editProdPrice').value, 10);
                if (!newPrice || newPrice < 0) return this.showToast('Цена указана неверно');

                let selectedImage = '';
                try {
                    selectedImage = await this.getSelectedEditPhoto();
                } catch (err) {
                    return this.showToast(err.message);
                }

                p.name = document.getElementById('editProdName').value.trim() || p.name;
                p.category = document.getElementById('editProdCat').value;
                p.price = newPrice;
                p.image = selectedImage || p.image || PRODUCT_IMAGE_PLACEHOLDER;
                p.desc = document.getElementById('editProdDesc').value.trim();
                p.specs = this.specsFromText(document.getElementById('editProdSpecs').value);

                this.cart = this.cart.map(item => String(item.id) === String(p.id) ? { ...item, ...p, tId: item.tId } : item);
                this.saveDb();
                this.refreshCatalog();
                this.closeModal('editProductModal');
                e.target.reset();
                document.getElementById('editProdPhotoFile').value = '';
                this.showToast('Товар обновлён');
            },

            deleteProduct: function (id) {
                const p = this.getProductById(id);
                if (!p) return this.showToast('Товар не найден');
                const ok = confirm(`Удалить товар «${p.name}»?`);
                if (!ok) return;

                const index = db.findIndex(x => String(x.id) === String(id));
                if (index !== -1) db.splice(index, 1);
                this.cart = this.cart.filter(item => String(item.id) !== String(id));
                this.saveDb();
                this.closeModal('productModal');
                this.closeModal('editProductModal');
                this.refreshCatalog();
                this.showToast('Товар удалён');
            },

            saveDb: function () {
                localStorage.setItem('ds_db', JSON.stringify(db));
            },

            loadDb: function () {
                const saved = localStorage.getItem('ds_db');
                if (!saved) return;
                try {
                    const parsed = JSON.parse(saved);
                    db.length = 0;
                    parsed.forEach(p => db.push(p));
                } catch (err) {
                    console.warn('Не удалось загрузить каталог из localStorage', err);
                }
            },

            // ===== АВТОРИЗАЦИЯ (НОВОЕ) =====
            updateAuthUI: function () {
                const user = usersDB.getCurrentUser();
                const authBtn = document.getElementById('authBtn');
                if (user) {
                    authBtn.textContent = `👤 ${user.name}`;
                } else {
                    authBtn.textContent = 'Войти';
                }
            },

            setAuthMode: function (mode) {
                const title = document.getElementById('authTitle');
                const submit = document.getElementById('authSubmit');
                const toggleText = document.getElementById('authToggleText');
                const nameGroup = document.getElementById('authNameGroup');

                if (mode === 'login') {
                    title.textContent = 'Вход';
                    submit.textContent = 'Войти';
                    nameGroup.style.display = 'none';
                    toggleText.innerHTML = 'Нет аккаунта? <a href="#" id="authToggleLink" style="color: var(--accent-glow);">Зарегистрироваться</a>';
                    document.getElementById('authToggleLink').onclick = (e) => { e.preventDefault(); this.setAuthMode('register'); };
                } else {
                    title.textContent = 'Регистрация';
                    submit.textContent = 'Зарегистрироваться';
                    nameGroup.style.display = 'block';
                    toggleText.innerHTML = 'Уже есть аккаунт? <a href="#" id="authToggleLink" style="color: var(--accent-glow);">Войти</a>';
                    document.getElementById('authToggleLink').onclick = (e) => { e.preventDefault(); this.setAuthMode('login'); };
                }
            },

            handleAuth: function (e) {
                e.preventDefault();
                const email = document.getElementById('authEmail').value.trim();
                const password = document.getElementById('authPassword').value.trim();
                const name = document.getElementById('authName').value.trim();
                const isLogin = document.getElementById('authSubmit').textContent === 'Войти';

                if (!email || !password) return this.showToast('Заполните email и пароль');
                if (isLogin) {
                    const result = usersDB.login(email, password);
                    if (result.success) {
                        this.showToast(`👋 Добро пожаловать, ${usersDB.getCurrentUser().name}!`);
                        this.updateAuthUI();
                        this.renderProducts(this.currentFilter);
                        this.closeModal('authModal');
                    } else {
                        this.showToast('❌ ' + result.error);
                    }
                } else {
                    if (!name) return this.showToast('Введите ваше имя');
                    if (password.length < 6) return this.showToast('Пароль должен быть минимум 6 символов');
                    const result = usersDB.register(email, password, name);
                    if (result.success) {
                        this.showToast('✅ Регистрация успешна! Теперь войдите.');
                        this.setAuthMode('login');
                    } else {
                        this.showToast('❌ ' + result.error);
                    }
                }
            },

            logout: function () {
                if (!confirm('Выйти из аккаунта?')) return;
                usersDB.logout();
                this.updateAuthUI();
                this.renderProducts(this.currentFilter);
                this.closeModal('profileModal');
                this.showToast('Вы вышли из аккаунта');
            },

            renderProfile: function () {
                const user = usersDB.getCurrentUser();
                if (!user) return;

                const allFavorites = user.favorites.map(id => this.getProductById(id)).filter(Boolean);
                const ordersHTML = user.orders && user.orders.length ? user.orders.map((order) => `
                    <div style="background: rgba(255,255,255,0.05); padding: 15px; border-radius: 8px; margin-bottom: 10px;">
                        <div style="display:flex;justify-content:space-between;margin-bottom:5px;">
                            <span style="font-weight:600;">Заказ #${order.orderId}</span>
                            <span style="color:var(--accent-glow);">${order.total.toLocaleString()} ₸</span>
                        </div>
                        <div style="font-size:12px; color:var(--text-muted);">
                            ${order.items.map(i => i.name).join(', ')}
                        </div>
                        <div style="font-size:11px; color:#666; margin-top:5px;">${new Date(order.date).toLocaleString()}</div>
                    </div>
                `).join('') : '<p style="color:var(--text-muted);">У вас пока нет заказов</p>';

                document.getElementById('profileContent').innerHTML = `
                    <div style="margin-bottom: 20px;">
                        <div style="display:flex; justify-content:space-between; align-items:center;">
                            <div>
                                <h4 style="margin-bottom:5px;">${this.escapeHTML(user.name)}</h4>
                                <p style="color:var(--text-muted); font-size:13px;">${this.escapeHTML(user.email)}</p>
                                <p style="color:var(--text-muted); font-size:11px;">Зарегистрирован: ${new Date(user.createdAt).toLocaleDateString()}</p>
                            </div>
                            <button class="btn-outline" style="padding:8px 16px; font-size:12px;" onclick="app.logout()">Выйти</button>
                        </div>
                    </div>
                    <hr style="border-color: rgba(255,255,255,0.1); margin: 20px 0;">
                    
                    <h4 style="margin-bottom: 15px;">❤️ Избранное (${allFavorites.length})</h4>
                    ${allFavorites.length ? allFavorites.map(p => `
                        <div style="display:flex; align-items:center; gap:15px; background:rgba(255,255,255,0.03); padding:10px; border-radius:8px; margin-bottom:8px;">
                            <img src="${this.getProductImage(p)}" style="width:50px; height:50px; object-fit:contain; background:white; border-radius:4px; padding:5px;">
                            <div style="flex:1;">
                                <div style="font-weight:600;">${this.escapeHTML(p.name)}</div>
                                <div style="font-size:13px; color:var(--accent-glow);">${p.price.toLocaleString()} ₸</div>
                            </div>
                            <button class="btn" style="padding:4px 12px; font-size:12px;" onclick="app.addToCart(${p.id})">В корзину</button>
                        </div>
                    `).join('') : '<p style="color:var(--text-muted);">Нет избранных товаров</p>'}
                    
                    <hr style="border-color: rgba(255,255,255,0.1); margin: 20px 0;">
                    
                    <h4 style="margin-bottom: 15px;">📦 История заказов (${user.orders ? user.orders.length : 0})</h4>
                    ${ordersHTML}
                `;
            },

            showToast: function (msg) {
                const t = document.createElement('div');
                t.className = 'toast';
                t.innerText = msg;
                document.body.appendChild(t);
                setTimeout(() => { t.classList.add('show'); }, 10);
                setTimeout(() => { t.classList.remove('show'); setTimeout(() => t.remove(), 400); }, 3000);
            },

            // ===== ОБРАБОТЧИКИ СОБЫТИЙ (НОВОЕ) =====
            bindEvents: function () {
                // Поиск
                const searchInput = document.getElementById('searchInput');
                if (searchInput) {
                    searchInput.addEventListener('input', (e) => {
                        this.searchProducts(e.target.value);
                    });
                }

                // Фильтры
                document.querySelectorAll('.filter-btn').forEach(btn => {
                    btn.addEventListener('click', function() {
                        app.filterProducts(this.dataset.filter, this);
                    });
                });

                // Корзина
                document.getElementById('cartToggle').addEventListener('click', () => this.toggleCart());

                // Оформление
                document.getElementById('checkoutBtn').addEventListener('click', () => this.openCheckout());
                document.getElementById('toPaymentBtn').addEventListener('click', () => this.goToPayment());
                document.getElementById('backToContactsBtn').addEventListener('click', () => this.backToContacts());
                document.getElementById('payBtn').addEventListener('click', function() {
                    app.processPayment(this);
                });

                // Оплата
                document.querySelectorAll('.pay-opt').forEach(opt => {
                    opt.addEventListener('click', function() {
                        app.selectPayment(this.dataset.payment, this);
                    });
                });

                // Лояльность
                document.getElementById('loyaltyBtn').addEventListener('click', () => this.checkLoyalty());
                document.getElementById('contractInput').addEventListener('keypress', (e) => {
                    if (e.key === 'Enter') this.checkLoyalty();
                });

                // Отзывы
                document.getElementById('reviewForm').addEventListener('submit', (e) => this.submitReview(e));

                // Администрирование
                document.getElementById('addProductBtn').addEventListener('click', () => this.openAddProductModal());
                document.getElementById('addProductForm').addEventListener('submit', (e) => this.submitNewProduct(e));
                document.getElementById('editProductForm').addEventListener('submit', (e) => this.submitEditProduct(e));

                // Авторизация
                document.getElementById('authBtn').addEventListener('click', () => {
                    if (usersDB.getCurrentUser()) {
                        document.getElementById('profileModal').classList.add('active');
                        this.renderProfile();
                    } else {
                        document.getElementById('authModal').classList.add('active');
                        this.setAuthMode('login');
                    }
                });

                document.getElementById('authForm').addEventListener('submit', (e) => this.handleAuth(e));

                // Закрытие модалок
                document.querySelectorAll('[data-close]').forEach(el => {
                    el.addEventListener('click', function() {
                        app.closeModal(this.dataset.close);
                    });
                });

                // Закрытие по клику вне
                document.querySelectorAll('.modal-overlay').forEach(modal => {
                    modal.addEventListener('click', function(e) {
                        if (e.target === this) {
                            this.classList.remove('active');
                        }
                    });
                });
            }
        };

        window.app = app;

        const style = document.createElement('style'); style.innerHTML = `@keyframes spin { 0% { transform: rotate(0deg); } 100% { transform: rotate(360deg); } }`; document.head.appendChild(style);
        window.onload = () => app.init();

document.addEventListener('click', function (event) {
    const target = event.target.closest('[data-click]');
    if (!target) return;
    event.preventDefault();
    Function('event', 'element', target.dataset.click)(event, target);
});

document.addEventListener('submit', function (event) {
    const target = event.target.closest('[data-submit]');
    if (!target) return;
    Function('event', 'element', target.dataset.submit)(event, target);
});

document.addEventListener('change', function (event) {
    const target = event.target.closest('[data-change]');
    if (!target) return;
    Function('event', 'element', target.dataset.change)(event, target);
});