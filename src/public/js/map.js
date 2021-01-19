var map = L.map('map-template').setView([51.505, -0.09], 13);
var marker = L.marker([1000,1000]);

L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(map);


function addMarker(ubication){
    const coords = [ubication.latlng.lat, ubication.latlng.lng];
    marker.remove();
    marker = L.marker(coords);
    map.addLayer(marker);
    map.panTo(coords);
}


document.getElementById('ubicate').addEventListener('click', () => {
    map.locate({ enableHighAccuracy: true });
    map.on('locationfound', e => {
        addMarker(e);
    });
})


map.on('click', (e) => {
    addMarker(e);
})

