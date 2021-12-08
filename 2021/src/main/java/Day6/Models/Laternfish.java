package Day6.Models;

public class Laternfish {
    private Integer internalTimer;

    public Integer getInternalTimer() {
        return internalTimer;
    }

    public Laternfish(Integer initialValue){
        this.internalTimer = initialValue;
    }

    public void increment() {
        internalTimer--;
    }

    public void resetTimer() {
        internalTimer = 6;
    }
}
