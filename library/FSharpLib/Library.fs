module CoreGame 

open UnityEngine

type DemoComponent ()=
    inherit MonoBehaviour ()

    [<SerializeField>]
    let mutable message: string = "Insert message here"
    
    member this.Start () =
        Debug.Log message

    member this.Update () =
        Debug.Log message