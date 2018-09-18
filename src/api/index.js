import axios from 'axios';
export const URL='http://localhost:99/'
const header={
    headers: {
        "Accept": "application/json;odata=verbose",
        'Content-Type': 'application/json;charset=UTF-8'
    }
}
export const getAllVisitItem=()=>axios.get(
    URL + "/api/WellVisiteds",
    header
)
export const getItem=(id)=>axios.get(
   URL+ "api/WellVisiteds/"+id,
   header
)
export const saveItem=(data)=>axios.post(
    URL + "api/WellVisiteds",data ,
    header
)
export const updateItem=(data)=>axios.put(
    URL + "api/WellVisiteds/"+data.ID,data,
    header
)

export const removeItem=(id,storeIndex)=>axios.delete(
    URL+"api/"+storeIndex +"/"+id,
    header
)
export const getWellProfile=(id)=>axios.get(
    URL+"api/WellProfiles/"+id,
    header
)
// export const saveItem=()=>axios.post(
//     URL + "_Layouts/15/AutomateFormProcess/Services.aspx/GetDisplayFields", {
//         listId: listId,
//         formType: formType,
//         contentTypeId: contentTypeId
//     }, header
// )