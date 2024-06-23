public static class StringData
{
    // Animation
    public static string AnimationMove = "Move";
    public static string AnimationHit = "Hit";
    public static string AnimationDead = "Dead";
    // Tag
    public static string TagBackground = "Background";
    public static string TagReposRange = "RepositionRange";
    public static string TagWeapon = "Weapon";
    public static string TagMonster = "Monster";
    // Resource Path
    public static string pathWeaponData = "WeaponData";
    public static string pathCharacterData = "CharacterData";
    public static string pathMonsterData = "MonsterData";
    // Status
    public static string Hp = "ü�� ��ȭ";
    public static string Speed = "�̵��ӵ� ��ȭ";
    public static string Damaga = "���ݷ� ��ȭ";
    public static string Delay = "���ݼӵ� ��ȭ";
    public static string Count = "���� ��ȭ";
}
public enum WeaponType
{
    Spin,
    Shoot
}

public enum UpgradeType
{
    Hp,
    Speed,
    Count,
    Damage,
    Delay
}

public class UpgradeData
{
    public UpgradeType upgradeType;
    public int weight;

    public UpgradeData(UpgradeType _type, int _weight)
    {
        upgradeType = _type;
        weight = _weight;
    }
}