
let poltronasSelecionadas = [];



function validaBotao() {
    if (poltronasSelecionadas.length == []) {
        $('#btnComprar').addClass('disableField')
    }
    else {
        $('#btnComprar').removeClass('disableField')
    }
}

function selecionarPoltronas(name) {

    

    if (poltronasSelecionadas.includes(name)) {
        poltronasSelecionadas.splice(poltronasSelecionadas.indexOf(name), 1);
    }
    else {
        poltronasSelecionadas.push(name);
    }
    validaBotao();


}

async function RequestAjax(url, params, metodo) {
    metodo = metodo == undefined || metodo == "" ? "GET" : metodo;

    let result;

    await $.ajax({

        url: url,
        data: params,
        method: metodo,
        async: true
    }).done(async function (data) {

        result = data;
    });

    return result;
}



async function comprarPoltronas(id) {
    alert("Poltrona(s) - " + poltronasSelecionadas + " foi(foram) comprada(compradas)");

    let objPARAM = {};
    objPARAM.id = id;
    objPARAM.poltronas = poltronasSelecionadas

    let url = "/Home/ComprarPoltronas";
    let data = await RequestAjax(url, objPARAM, "POST")
    if (data) {
        
       

        setTimeout(function () { location.href = '../Voos' }, 3000)
       

    }
}


