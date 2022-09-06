var infobox;
var map;
function getMap() {
    map = new Microsoft.Maps.Map(document.getElementById('mymap'), {});
    infobox = new Microsoft.Maps.Infobox(map.getCenter(), {
        visible: false
    });
    infobox.setMap(map);
}

function addPin(pin) {
    var obj = JSON.parse(pin);
    var location = {
        latitude: obj.latitude,
        longitude: obj.longitude
    };
    var metadata = {
        title: obj.title,
        description: obj.description
    };
    var realpin = new Microsoft.Maps.Pushpin(location,metadata);
    Microsoft.Maps.Events.addHandler(realpin, 'click', pushpinClicked);
    map.entities.push(realpin);
}

function pushpinClicked(e) {
    //Make sure the infobox has metadata to display.
    if (e.target.metadata) {
        //Set the infobox options with the metadata of the pushpin.
        infobox.setOptions({
            location: e.target.getLocation(),
            title: e.target.metadata.title,
            description: e.target.metadata.description,
            visible: true
        });
    }
}
