using Xunit;
namespace ExercismCSharp.Tests;

public class AnnalynsInfiltrationTests
{
    [Fact]
    public void CanFastAttack()
    {
        var knightIsAwake = true;
        Assert.False(QuestLogic.CanFastAttack(knightIsAwake));

        knightIsAwake = false;
        Assert.True(QuestLogic.CanFastAttack(knightIsAwake));
    }

    [Fact]
    public void CanSpy()
    {
        var knightIsAwake = false;
        var archerIsAwake = false;
        var prisonerIsAwake = false;
        Assert.False(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        knightIsAwake = true;
        archerIsAwake = false;
        prisonerIsAwake = false;
        Assert.True(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = false;
        Assert.True(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        knightIsAwake = false;
        archerIsAwake = false;
        prisonerIsAwake = true;
        Assert.True(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        knightIsAwake = true;
        archerIsAwake = true;
        prisonerIsAwake = false;
        Assert.True(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = true;
        Assert.True(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        knightIsAwake = true;
        archerIsAwake = false;
        prisonerIsAwake = true;
        Assert.True(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        knightIsAwake = true;
        archerIsAwake = true;
        prisonerIsAwake = true;
        Assert.True(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
    }

    [Fact]
    public void CanSignalPrisoner()
    {
        var archerIsAwake = false;
        var prisonerIsAwake = false;
        Assert.False(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));

        archerIsAwake = true;
        prisonerIsAwake = false;
        Assert.False(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));

        archerIsAwake = true;
        prisonerIsAwake = true;
        Assert.False(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));

        archerIsAwake = false;
        prisonerIsAwake = true;
        Assert.True(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));
    }

    [Fact]
    public void CanFreePrisoner()
    {
        var knightIsAwake = false;
        var archerIsAwake = false;
        var prisonerIsAwake = false;
        var petDogIsPresent = false;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = true;
        archerIsAwake = false;
        prisonerIsAwake = false;
        petDogIsPresent = false;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = false;
        petDogIsPresent = false;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));  

        knightIsAwake = true;
        archerIsAwake = true;
        prisonerIsAwake = false;
        petDogIsPresent = false;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = true;
        archerIsAwake = true;
        prisonerIsAwake = true;
        petDogIsPresent = false;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = true;
        petDogIsPresent = true;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = true;
        archerIsAwake = true;
        prisonerIsAwake = true;
        petDogIsPresent = true;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));      

        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = true;
        petDogIsPresent = false;
        Assert.False(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = false;
        archerIsAwake = false;
        prisonerIsAwake = false;
        petDogIsPresent = true;
        Assert.True(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = false;
        archerIsAwake = false;
        prisonerIsAwake = true;
        petDogIsPresent = true;
        Assert.True(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = false;
        archerIsAwake = false;
        prisonerIsAwake = true;
        petDogIsPresent = false;
        Assert.True(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = true;
        archerIsAwake = false;
        prisonerIsAwake = false;
        petDogIsPresent = true;
        Assert.True(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        knightIsAwake = true;
        archerIsAwake = false;
        prisonerIsAwake = true;
        petDogIsPresent = true;
        Assert.True(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
    }
}