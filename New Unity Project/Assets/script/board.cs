using UnityEngine.Tilemaps;
using UnityEngine;

public class board : MonoBehaviour
{
    public Tilemap tilemap {get; private set;}
    public Piece activePiece {get; private set;}
    public TetrominoData[] tetraminos;
    public Vector3Int SpawnPosition;

    private void Awake()
    {
        this.tilemap = GetComponentInChildren<Tilemap>();
        this.activePiece = GetComponentInChildren<Piece>();
        for (int i = 0; i < this.tetraminos.Length; i++){
            this.tetraminos[i].Initialize();
        }
    }

    private void Start()
    {
        SPawnPiece();
    }
    public void SPawnPiece()
    {
        int random = Random.Range(0, this.tetraminos.Length);
        TetrominoData data = this.tetraminos[random];

        this.activePiece.Initialize(this, this.SpawnPosition, data);
        set(this.activePiece);


    }
    public void Set(Piece piece)
    {
        for (int i = 0; i < piece.cells.Length; i++){
            Vector3Int tilePosition = piece.cells[i] + piece.position;
            this.tilemap.SetTile(tilePositio, piece.data.tile);
        }
    }
       
}
