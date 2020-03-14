/**
 * Função para validar campo de pesquisa na view Index. 
 */
function validarCampoPesquisa(){
    if(document.getElementById('pesquisarLivro').value == ''){
        alert("Por favor, preencha o campo de pesquisa!")
        location.reload()
    }    
}

/**
 * Função para limpar campos na view Create. 
 */
function limparCamposCriacao(){
    document.getElementById('livroTitulo').value=''
    document.getElementById('livroAutor').value=''
    document.getElementById('livroGenero').value=''
    document.getElementById('livroLancamento').value=''
    document.getElementById('livroEditora').value=''
    location.reload() 
}