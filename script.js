// 🔑 Cole a sua chave de API do OpenWeather aqui dentro das aspas simples!
const API_KEY = 'f1e71feeba5a354607af75b6d650b853'; 

let map; // Variável para controlar o mapa

// Monitora o botão de buscar
document.querySelector('#btnBuscar').addEventListener('click', () => {
    pegarCoordenadas();
});

// Monitora se o usuário apertar "Enter" no teclado
document.querySelector('#inputCidade').addEventListener('keyup', (e) => {
    if (e.key === 'Enter') {
        pegarCoordenadas();
    }
});

// c) function showWarning(msg) - Exibe mensagens de aviso/erro na tela
function showWarning(msg) {
    document.querySelector('.aviso').innerHTML = msg;
}

// b) function clearInfo() - Limpa as buscas anteriores
function clearInfo() {
    showWarning('');
    document.querySelector('.resultado').style.display = 'none';
}

// a) function showInfo(obj) - Atualiza a tela com os dados reais retornados pela API
function showInfo(obj) {
    showWarning(''); // Limpa o "Carregando..."
    
    // Captura os dados do JSON recebido
    const temp = Math.round(obj.current.temp); 
    const descricao = obj.current.weather[0].description;
    const icone = obj.current.weather[0].icon;
    const vento = Math.round(obj.current.wind_speed * 3.6); 

    // Atualiza o HTML
    document.querySelector('.titulo').innerHTML = `Clima Atual`;
    document.querySelector('.tempInfo').innerHTML = `${temp}<sup>°C</sup>`;
    document.querySelector('.ventoInfo').innerHTML = `${vento} km/h`;
    document.querySelector('.climaImg').setAttribute('src', `https://openweathermap.org/img/wn/${icone}@2x.png`);
    document.querySelector('.climaDescricao').innerHTML = descricao;

    // Torna visível a área de resultados
    document.querySelector('.resultado').style.display = 'block';
}

// Função para gerar/atualizar o mapa na tela do usuário
function updateMap(lat, lon, nomeCidade) {
    if (!map) {
        map = L.map('map').setView([lat, lon], 12);
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '© OpenStreetMap contributors'
        }).addTo(map);
    } else {
        map.setView([lat, lon], 12);
    }

    // Limpa marcadores anteriores
    map.eachLayer((layer) => {
        if (layer instanceof L.Marker) {
            map.removeLayer(layer);
        }
    });

    // Adiciona o pino no mapa
    L.marker([lat, lon]).addTo(map)
        .bindPopup(`<b>${nomeCidade}</b>`)
        .openPopup();
}

// Passo 1: Busca as coordenadas da cidade digitada de forma segura
async function pegarCoordenadas() {
    const cidadeInput = document.querySelector('#inputCidade').value.trim();

    if (cidadeInput === '') {
        showWarning("Digita uma cidade aí primeiro, pô!");
        return;
    }

    clearInfo();
    showWarning('Procurando cidade...');

    const geoUrl = `https://api.openweathermap.org/geo/1.0/direct?q=${encodeURIComponent(cidadeInput)}&limit=1&appid=${API_KEY}`;

    try {
        const response = await fetch(geoUrl);
        
        // Se a requisição falhar (como erro de API Key inválida)
        if (!response.ok) {
            throw new Error('Erro na requisição! Verifique se sua API Key foi copiada corretamente.');
        }

        const data = await response.json();

        // 🛡️ CORREÇÃO IMPORTANTE: Aqui garantimos que se o data vier vazio, não tentamos ler o 'lat'
        if (!data || data.length === 0) {
            throw new Error('Não encontrei essa cidade. Verifique a ortografia ou se sua conta na OpenWeather já foi confirmada por e-mail!');
        }

        const { lat, lon, name, country } = data[0];
        
        // Se achou, atualiza o mapa imediatamente
        updateMap(lat, lon, `${name}, ${country}`);

        // Vai buscar o clima com as coordenadas encontradas
        buscarClima(lat, lon);

    } catch (error) {
        // Mostra a mensagem tratada e em português na tela, impedindo que o app quebre
        showWarning(error.message);
    }
}

// Passo 2: Busca a temperatura real do local com as coordenadas
async function buscarClima(lat, lon) {
    showWarning('Buscando clima atualizado...');

    const climaUrl = `https://api.openweathermap.org/data/3.0/onecall?lat=${lat}&lon=${lon}&appid=${API_KEY}&units=metric&lang=pt_br`;

    try {
        const response = await fetch(climaUrl);
        
        if (!response.ok) {
            throw new Error('Não consegui carregar o clima. Talvez sua API Key não tenha acesso à versão One Call 3.0. É necessário ativar o plano na conta!');
        }

        const json = await response.json();
        showInfo(json);

    } catch (error) {
        showWarning(error.message);
    }
}