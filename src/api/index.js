import axios from 'axios';
import $ from 'jquery'
export const URL=''
const header={
    headers: {

        
        "Accept": "application/json;odata=verbose",
        'Content-Type': 'application/json;charset=UTF-8',
        // 'Authorization' : 'Bearer ' +"5hIOXDhhUh3100nqeRj4ZUa_rLN2Ru05G8C-WzgVnUjDbDdjNTNKAeRgfQiJRJoceYizp14ddSkUKDOIfet7lGBC8RQNuEN9ZpGuqlJ01yuzlnyt-wDdL4C5pLYQlqh4hcP2zxbKvNRUq4wMqqW6PjEdB3qlHqOT2SFyaF7CEuhJF8Bjrzic5oEocsxuLK4kZK-afbK0deuYylAPJvJzO5XvH7ExCZ3IfY-NPBRdv5EDEkuwnlS9TCvG-1rYk8LIZaLZpIHRbSFPMTQze5KnqVlWa8HIodApsCZwPjiYIv5bY-VrpXSE9qGyqNzyEgKsG5Rpw-KV5VtVeA04P3vdFW2vKne6XdOulj3Qh8NjRCZ0AwYlKAG9M0KtCZevpUOYdhpaYJMiBg1l2vz9rASlgacrYmdv2wpWVrN5h-KhMxt7WECM9JyC1ATxUPmbZQoI_qo3j4US2wN581RypVDvp5SonPoA__0CT8KsXMlTCjM"//sessionStorage.getItem("accessToken")
    }
}

export const getAllItem=(storeIndex,select)=>axios.get(
    URL + "/api/"+storeIndex+(select&&select!=''?'?$select='+select:''),
    header
)
// export const getAllItem=(storeIndex,select)=> $.ajax({
//     type: 'GET',
//     url: URL + "/api/"+storeIndex,
// })
export const getItem=(id,storeIndex)=>axios.get(
   URL+ "api/"+storeIndex+ "/"+id ,
   header
)
export const getItemByCode=(id,storeIndex)=>axios.get(
    URL+ "api/"+storeIndex+ "?code="+id,
    header
 )
export const saveItem=(data,storeIndex)=>axios.post(
    URL + "api/"+storeIndex ,data,
    header
)
export const updateItem=(data,storeIndex)=>axios.put(
    URL + "api/"+storeIndex+"/"+data.ID,data,
    header
)

export const removeItem=(id,storeIndex)=>axios.delete(
    URL+"api/"+storeIndex +"/"+id,
    header
)
export const getMetaData=(id)=>axios.get(
    URL+ "api/metadata/"+ id,
    header
) 
export const uploadFile=(data)=>axios.post(
    URL+ "api/upload/", data,
    header
)  

// export const saveItem=()=>axios.post(
//     URL + "_Layouts/15/AutomateFormProcess/Services.aspx/GetDisplayFields", {
//         listId: listId,
//         formType: formType,
//         contentTypeId: contentTypeId
//     }, header
// )