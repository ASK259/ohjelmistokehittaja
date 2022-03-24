window.onload = function() { // Piilottaa turhat tekstit, kun sivu avautuu
  let pi1 = document.getElementsByTagName("h2")[0];
  let pi2 = document.getElementsByTagName("h3")[0];
  let pi3 = document.getElementsByTagName("h3")[1];
  pi1.hidden = true;
  pi2.hidden = true;
  pi3.hidden = true;
}

function saa() {
  let paikka = document.getElementById("paikka").value; // Noutaa kohteen johon halutaan hakea säätietoja
  fetch("https://weatherdbi.herokuapp.com/data/weather/"+paikka) //API
    .then(response=>response.json()) // API:n tietojen hakua
    .then(response=>{
      let si = response.region; // Paikan nimi muuttujaan
      let tu = response.currentConditions; // Muuttuja tämänhetkisille tiedoille
      let seu = response.next_days[0]; // muuttuja seuraavien päivien tiedoille
      let seu1 = response.next_days[1]; // muuttuja seuraavien päivien tiedoille
      let seu2 = response.next_days[2]; // muuttuja seuraavien päivien tiedoille
      let pi1 = document.getElementsByTagName("h2")[0]; // Muuttuja Tänään-otsikolle
      let pi2 = document.getElementsByTagName("h3")[0]; // Muuttuja Huomenna-otsikolle
      let pi3 = document.getElementsByTagName("h3")[1]; // Muuttuja Ylihuomenna-otsikolle
      pi1.hidden = false; // otsikko näkyväksi
      pi2.hidden = false; // otsikko näkyväksi
      pi3.hidden = false; // otsikko näkyväksi
      document.getElementById("ti1").textContent = `${si}, milloin: ${tu.dayhour}, lämpötila: ${tu.temp["c"]}°C, ilmankosteus:${tu.humidity}, tuuli${tu.wind["km"]} km/h`; // tämänhetkinen sää
      document.getElementById("ku").innerHTML = '<img src =' + tu.iconURL + '>'; // ikoni säälle
      document.getElementById("se").textContent = `Päivä: ${seu1.day}, kuvaus: ${seu1.comment}, korkein lämpötila: ${seu1.max_temp["c"]}°C, alin lämpötila: ${seu1.min_temp["c"]}°C`; // huominen sää
      document.getElementById("seKu").innerHTML = '<img src =' + seu1.iconURL + '>'; // ikoni säälle
      document.getElementById("se1").textContent = `Päivä: ${seu2.day}, kuvaus: ${seu2.comment}, korkein lämpötila: ${seu2.max_temp["c"]}°C, alin lämpötila: ${seu2.min_temp["c"]}°C`; // ylihuominen sää
      document.getElementById("seKu1").innerHTML = '<img src =' + seu2.iconURL + '>'; // ikoni säälle
    })
    .catch(err=>console.error(err)); // API:n virheilmoitus konsoliin
}
