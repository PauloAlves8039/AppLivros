/**
 * Função para validar campo de pesquisa na view Index. 
 */
function validarCampoPesquisa(){
    if(document.getElementById('pesquisarLivro').value == ''){
        alert("Por favor, preencha o campo de pesquisa!")
        location.reload()
    }    
}
