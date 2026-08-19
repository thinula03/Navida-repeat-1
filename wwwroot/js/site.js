(function () {
    const coordinates = document.getElementById("researcher-coordinates");

    if (!coordinates) {
        return;
    }

    const latitude = Number(coordinates.dataset.lat);
    const longitude = Number(coordinates.dataset.lng);

    if (Number.isFinite(latitude) && Number.isFinite(longitude)) {
        coordinates.textContent = `${latitude.toFixed(6)}, ${longitude.toFixed(6)}`;
    }
})();
